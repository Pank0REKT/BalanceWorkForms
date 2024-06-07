using System.Resources;
using System.Windows.Forms;

namespace BalanceWorkForms
{
    public partial class Form1 : Form
    {
        private bool _isForceClose = false;
        private NotifyIcon _ni = new NotifyIcon();
        private ContextMenuStrip _menu = new ContextMenuStrip();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int seconds = 0;
        private bool _isOn = false;
        private string _activeTaskName = string.Empty;

        public Form1()
        {
            InitializeComponent();
            ContextMenuInitialize();
            _ni.Icon = Properties.Resources.capybara;
            _ni.Visible = false;
            _ni.MouseClick += delegate (object? sender, MouseEventArgs args)
            {
                TrayClick(args);
            };
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            RefreshButtonsStates();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            labelTimer.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
            if (timer.Enabled)
            {
                RefreshContextMenu(labelTimer.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isForceClose)
            {
                e.Cancel = true;
                this.Hide();
                _ni.Visible = true;
            }
            else
            {
                _ni.Dispose();
            }
        }

        private void TrayClick(MouseEventArgs args)
        {
            if (args.Clicks == 2)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                _ni.Visible = false;
            }
            else if (args.Button == MouseButtons.Right)
            {
                if (timer.Enabled)
                {
                    RefreshContextMenu(labelTimer.Text);
                }
                else
                {
                    RefreshContextMenu("Начать новую задачу");
                }
                _menu.Show(Cursor.Position);
            }
        }

        private void ContextMenuInitialize()
        {
            var items = new ToolStripMenuItem[] { new ToolStripMenuItem("Открыть"), new ToolStripMenuItem("Закрыть программу") };
            _menu.Items.AddRange(items);
            _menu.Items[0].Click += delegate (object? sender, EventArgs args)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                _ni.Visible = false;
            };
            _menu.Items[1].Click += delegate (object? sender, EventArgs args)
            {
                _isForceClose = true;
                this.Close();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                _isOn = false;
                seconds = 0;
                listBoxTasks.Items.Add($"{labelTimer.Text}-{textBoxTaskName.Text}");
                textBoxTaskName.Text = string.Empty;
                _activeTaskName = string.Empty;
                labelTimer.Text = "00:00:00";
                textBoxTaskName.Enabled = true;
                buttonStartStop.Text = "Старт";
            }
            else
            {
                if (!string.IsNullOrEmpty(textBoxTaskName.Text))
                {
                    timer.Start();
                    _isOn = true;
                    _activeTaskName = textBoxTaskName.Text;
                    textBoxTaskName.Enabled = false;
                    buttonStartStop.Text = "Стоп";
                }
                else
                {
                    MessageBox.Show("Необходимо ввести название задачи!", "Внимание");
                }
            }
            RefreshButtonsStates();
        }

        private void RefreshContextMenu(string text)
        {
            _menu.Items[0].Text = text;
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem is not null)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }

        private void RefreshButtonsStates()
        {
            if (listBoxTasks.Items.Count > 0)
            {
                buttonSaveTasks.Enabled = true;
            }
            else
            {
                buttonSaveTasks.Enabled = false;
            }
            if (listBoxTasks.SelectedItems.Count > 0)
            {
                buttonDeleteTask.Enabled = true;
            }
            else
            {
                buttonDeleteTask.Enabled = false;
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshButtonsStates();
        }
    }
}
