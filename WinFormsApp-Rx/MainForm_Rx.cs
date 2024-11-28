using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace WinFormsApp_Rx
{
    public partial class MainForm_Rx : Form
    {
        WorkerRx _worker;
        public MainForm_Rx()
        {
            InitializeComponent();
        }

        private void MainForm_Rx_Load(object sender, EventArgs e)
        {
            Observable.Interval(TimeSpan.FromSeconds(1))
                      .ObserveOn(SynchronizationContext.Current)
                      .Subscribe(x => timeLabel.Text = DateTime.Now.ToLongTimeString());
        }

        private void start_Click(object sender, EventArgs e)
        {
            _worker = new WorkerRx();
            startButton.Enabled = false;

            Action onCompleted = () =>
            {
                string message = _worker.Cancelled ? "Process cancelled" : "Process finished";
                MessageBox.Show(message);
                startButton.Enabled = true;
            };

            Action<Exception> onException = e =>
            {
                MessageBox.Show(e.Message);
                startButton.Enabled = true;
            };

            _worker.Work()
                .ToObservable(Scheduler.Default)
                .ObserveOn(SynchronizationContext.Current)
                .Subscribe(x => progressBar.Value = x, onException, onCompleted);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (_worker != null)
            {
                _worker.Cancel();
            }
        }
    }
}
