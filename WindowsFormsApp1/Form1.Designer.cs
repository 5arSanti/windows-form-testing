using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        // Componentes
        private System.ComponentModel.IContainer components = null;
        private Button button;
        private CheckBox checkBox;
        private ComboBox comboBox;
        private Label label;
        private RadioButton radioButton;
        private TextBox textBox;
        private DataGridView dataGridView;

        // Método para inicializar componentes
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(455, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 30);
            this.button.TabIndex = 0;
            this.button.Text = "Click Me";
            this.button.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.Location = new System.Drawing.Point(455, 58);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(100, 20);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Check Me";
            // 
            // comboBox
            // 
            this.comboBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.comboBox.Location = new System.Drawing.Point(20, 21);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(150, 21);
            this.comboBox.TabIndex = 2;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(20, 58);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 20);
            this.label.TabIndex = 3;
            this.label.Text = "This is a label";
            // 
            // radioButton
            // 
            this.radioButton.Location = new System.Drawing.Point(23, 81);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(100, 20);
            this.radioButton.TabIndex = 4;
            this.radioButton.Text = "Select Me";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(455, 84);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(150, 20);
            this.textBox.TabIndex = 5;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView.Location = new System.Drawing.Point(455, 110);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(300, 150);
            this.dataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(775, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Ejemplo de Controles en Windows Forms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button button1;
    }
}

