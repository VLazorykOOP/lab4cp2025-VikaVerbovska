namespace ComputerSalesApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewComputers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtSoundcard;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblSoundcard;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewComputers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnExit = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtCPU = new TextBox();
            txtFrequency = new TextBox();
            txtGPU = new TextBox();
            txtRAM = new TextBox();
            txtSoundcard = new TextBox();
            txtHDD = new TextBox();
            txtSearch = new TextBox();
            lblId = new Label();
            lblName = new Label();
            lblCPU = new Label();
            lblFrequency = new Label();
            lblGPU = new Label();
            lblRAM = new Label();
            lblSoundcard = new Label();
            lblHDD = new Label();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewComputers
            // 
            dataGridViewComputers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComputers.Location = new Point(12, 12);
            dataGridViewComputers.Name = "dataGridViewComputers";
            dataGridViewComputers.RowHeadersWidth = 51;
            dataGridViewComputers.Size = new Size(600, 300);
            dataGridViewComputers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(630, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(630, 57);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(630, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(350, 320);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(745, 157);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(120, 27);
            txtId.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(745, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 27);
            txtName.TabIndex = 9;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(745, 227);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(120, 27);
            txtCPU.TabIndex = 11;
            // 
            // txtFrequency
            // 
            txtFrequency.Location = new Point(745, 262);
            txtFrequency.Name = "txtFrequency";
            txtFrequency.Size = new Size(120, 27);
            txtFrequency.TabIndex = 13;
            // 
            // txtGPU
            // 
            txtGPU.Location = new Point(745, 297);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(120, 27);
            txtGPU.TabIndex = 15;
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(745, 332);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(120, 27);
            txtRAM.TabIndex = 17;
            // 
            // txtSoundcard
            // 
            txtSoundcard.Location = new Point(745, 367);
            txtSoundcard.Name = "txtSoundcard";
            txtSoundcard.Size = new Size(120, 27);
            txtSoundcard.TabIndex = 19;
            // 
            // txtHDD
            // 
            txtHDD.Location = new Point(745, 402);
            txtHDD.Name = "txtHDD";
            txtHDD.Size = new Size(120, 27);
            txtHDD.TabIndex = 21;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(85, 324);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 27);
            txtSearch.TabIndex = 23;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(630, 160);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 6;
            lblId.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(630, 195);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 8;
            lblName.Text = "Назва:";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(630, 230);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(39, 20);
            lblCPU.TabIndex = 10;
            lblCPU.Text = "CPU:";
            // 
            // lblFrequency
            // 
            lblFrequency.AutoSize = true;
            lblFrequency.Location = new Point(630, 265);
            lblFrequency.Name = "lblFrequency";
            lblFrequency.Size = new Size(66, 20);
            lblFrequency.TabIndex = 12;
            lblFrequency.Text = "Частота:";
            // 
            // lblGPU
            // 
            lblGPU.AutoSize = true;
            lblGPU.Location = new Point(630, 300);
            lblGPU.Name = "lblGPU";
            lblGPU.Size = new Size(40, 20);
            lblGPU.TabIndex = 14;
            lblGPU.Text = "GPU:";
            // 
            // lblRAM
            // 
            lblRAM.AutoSize = true;
            lblRAM.Location = new Point(630, 335);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(44, 20);
            lblRAM.TabIndex = 16;
            lblRAM.Text = "RAM:";
            // 
            // lblSoundcard
            // 
            lblSoundcard.AutoSize = true;
            lblSoundcard.Location = new Point(630, 370);
            lblSoundcard.Name = "lblSoundcard";
            lblSoundcard.Size = new Size(109, 20);
            lblSoundcard.TabIndex = 18;
            lblSoundcard.Text = "Звукова карта:";
            // 
            // lblHDD
            // 
            lblHDD.AutoSize = true;
            lblHDD.Location = new Point(630, 405);
            lblHDD.Name = "lblHDD";
            lblHDD.Size = new Size(45, 20);
            lblHDD.TabIndex = 20;
            lblHDD.Text = "HDD:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 327);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(58, 20);
            lblSearch.TabIndex = 22;
            lblSearch.Text = "Пошук:";
            // 
            // Form1
            // 
            ClientSize = new Size(907, 450);
            Controls.Add(dataGridViewComputers);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnExit);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(txtCPU);
            Controls.Add(txtFrequency);
            Controls.Add(txtGPU);
            Controls.Add(txtRAM);
            Controls.Add(txtSoundcard);
            Controls.Add(txtHDD);
            Controls.Add(txtSearch);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(lblCPU);
            Controls.Add(lblFrequency);
            Controls.Add(lblGPU);
            Controls.Add(lblRAM);
            Controls.Add(lblSoundcard);
            Controls.Add(lblHDD);
            Controls.Add(lblSearch);
            Name = "Form1";
            Text = "Computer Sales App";
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
