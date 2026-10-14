using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchronous_Countdown
{
    public partial class FormMain : Form
    {
        public const int MAX = 10;
        CancellationTokenSource cts;
        public FormMain()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var progressPercent = new Progress<int>(value =>
            {
                pgsBarProgress.Value = value;
            });

            var progressInt = new Progress<int>(value =>
            {
                lblOutput.Text = value.ToString();
            });

            btnStart.Enabled = false;
            try
            {
                await Task.Run(() => Countdown(progressPercent, progressInt, cts.Token));
            }
            catch (OperationCanceledException ex)
            {
                btnStart.Enabled = true;
                pgsBarProgress.Value = 0;
                lblOutput.Text = "";
            }
  
            btnStart.Enabled = true;
            pgsBarProgress.Value = 0;
            lblOutput.Text = "";
        }

        private void Countdown(IProgress<int> progressPercent, IProgress<int> progressInt, CancellationToken token)
        {
            for (int i = 1; i <= MAX; i++)
            {
                Thread.Sleep(1000);
                var percent = (i * 100) / MAX;
                progressPercent.Report(percent);
                progressInt.Report(i);

                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            cts = new CancellationTokenSource();
        }
    }
}
