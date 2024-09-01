namespace _02_Laboratory_Exercise_1
{
    partial class CashierWindowQueue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listCashierQueue = new ListView();
            btnRefresh = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // listCashierQueue
            // 
            listCashierQueue.Font = new Font("Segoe UI", 11F);
            listCashierQueue.Location = new Point(112, 11);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(175, 272);
            listCashierQueue.TabIndex = 0;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11F);
            btnRefresh.Location = new Point(6, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 31);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 11F);
            btnNext.Location = new Point(6, 49);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // CashierWindowQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(296, 290);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Controls.Add(listCashierQueue);
            Name = "CashierWindowQueue";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listCashierQueue;
        private Button btnRefresh;
        private Button btnNext;
    }
}