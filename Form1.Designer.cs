using System.Windows.Forms;

namespace PracticeEvolveCodingTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newButtom = new System.Windows.Forms.Button();
            this.submitButtom = new System.Windows.Forms.Button();
            this.defaultHourlyRateLabel = new System.Windows.Forms.Label();
            this.defaultHourlyRateBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.state = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rightButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.state,
            this.title,
            this.type,
            this.duration,
            this.hourlyRate,
            this.total,
            this.leftButton,
            this.rightButton});
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // newButtom
            // 
            this.newButtom.Location = new System.Drawing.Point(0, 0);
            this.newButtom.Name = "newButtom";
            this.newButtom.Size = new System.Drawing.Size(96, 34);
            this.newButtom.TabIndex = 1;
            this.newButtom.Text = "New";
            this.newButtom.UseVisualStyleBackColor = true;
            this.newButtom.Click += new System.EventHandler(this.newButtom_Click);
            // 
            // submitButtom
            // 
            this.submitButtom.Location = new System.Drawing.Point(102, 0);
            this.submitButtom.Name = "submitButtom";
            this.submitButtom.Size = new System.Drawing.Size(203, 34);
            this.submitButtom.TabIndex = 2;
            this.submitButtom.Text = "Submit";
            this.submitButtom.UseVisualStyleBackColor = true;
            this.submitButtom.Click += new System.EventHandler(this.submitButtom_Click);
            // 
            // defaultHourlyRateLabel
            // 
            this.defaultHourlyRateLabel.AutoSize = true;
            this.defaultHourlyRateLabel.Location = new System.Drawing.Point(636, 9);
            this.defaultHourlyRateLabel.Name = "defaultHourlyRateLabel";
            this.defaultHourlyRateLabel.Size = new System.Drawing.Size(132, 17);
            this.defaultHourlyRateLabel.TabIndex = 3;
            this.defaultHourlyRateLabel.Text = "Default Hourly Rate";
            // 
            // defaultHourlyRateBox
            // 
            this.defaultHourlyRateBox.Location = new System.Drawing.Point(774, 9);
            this.defaultHourlyRateBox.Name = "defaultHourlyRateBox";
            this.defaultHourlyRateBox.Size = new System.Drawing.Size(104, 22);
            this.defaultHourlyRateBox.TabIndex = 4;
            this.defaultHourlyRateBox.Text = "250.50";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.newButtom);
            this.panel1.Controls.Add(this.defaultHourlyRateBox);
            this.panel1.Controls.Add(this.submitButtom);
            this.panel1.Controls.Add(this.defaultHourlyRateLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 34);
            this.panel1.TabIndex = 5;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Items.AddRange(new object[] {
            "Active",
            "Submitted"});
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Items.AddRange(new object[] {
            "Telephone Call",
            "Research",
            "Drafting Document"});
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // duration
            // 
            dataGridViewCellStyle3.Format = "h:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.duration.DefaultCellStyle = dataGridViewCellStyle3;
            this.duration.HeaderText = "Duration";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            // 
            // hourlyRate
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.hourlyRate.DefaultCellStyle = dataGridViewCellStyle4;
            this.hourlyRate.HeaderText = "Hourly Rate";
            this.hourlyRate.MinimumWidth = 6;
            this.hourlyRate.Name = "hourlyRate";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // leftButton
            // 
            this.leftButton.HeaderText = "Column1";
            this.leftButton.MinimumWidth = 6;
            this.leftButton.Name = "leftButton";
            this.leftButton.Text = "";
            // 
            // rightButton
            // 
            this.rightButton.HeaderText = "";
            this.rightButton.MinimumWidth = 6;
            this.rightButton.Name = "rightButton";
            this.rightButton.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newButtom;
        private System.Windows.Forms.Button submitButtom;
        private System.Windows.Forms.Label defaultHourlyRateLabel;
        private System.Windows.Forms.TextBox defaultHourlyRateBox;
        private Panel panel1;
        private DataGridViewComboBoxColumn state;
        private DataGridViewTextBoxColumn title;
        private DataGridViewComboBoxColumn type;
        private DataGridViewTextBoxColumn duration;
        private DataGridViewTextBoxColumn hourlyRate;
        private DataGridViewTextBoxColumn total;
        private DataGridViewButtonColumn leftButton;
        private DataGridViewButtonColumn rightButton;
    }
}

