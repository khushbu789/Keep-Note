namespace KeepNote
{
    partial class keep_note
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.group_box = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.text_title = new System.Windows.Forms.TextBox();
            this.text_note = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.group_box2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.group_box.SuspendLayout();
            this.group_box2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // group_box
            // 
            this.group_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_box.Controls.Add(this.text_note);
            this.group_box.Controls.Add(this.text_title);
            this.group_box.Controls.Add(this.label_note);
            this.group_box.Controls.Add(this.label_title);
            this.group_box.Controls.Add(this.label1);
            this.group_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_box.Location = new System.Drawing.Point(28, 32);
            this.group_box.Name = "group_box";
            this.group_box.Size = new System.Drawing.Size(465, 321);
            this.group_box.TabIndex = 0;
            this.group_box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keep Note";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(15, 57);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(201, 29);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Reminder Title :";
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_note.Location = new System.Drawing.Point(15, 133);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(204, 29);
            this.label_note.TabIndex = 2;
            this.label_note.Text = "Reminder Note :";
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(211, 57);
            this.text_title.Multiline = true;
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(236, 52);
            this.text_title.TabIndex = 3;
            // 
            // text_note
            // 
            this.text_note.Location = new System.Drawing.Point(211, 130);
            this.text_note.Multiline = true;
            this.text_note.Name = "text_note";
            this.text_note.Size = new System.Drawing.Size(236, 168);
            this.text_note.TabIndex = 4;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(48, 379);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(127, 67);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(199, 379);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(127, 67);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(348, 379);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(127, 67);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // group_box2
            // 
            this.group_box2.Controls.Add(this.GridView);
            this.group_box2.Controls.Add(this.button_search);
            this.group_box2.Controls.Add(this.text_search);
            this.group_box2.Controls.Add(this.label2);
            this.group_box2.Location = new System.Drawing.Point(517, 32);
            this.group_box2.Name = "group_box2";
            this.group_box2.Size = new System.Drawing.Size(454, 414);
            this.group_box2.TabIndex = 4;
            this.group_box2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reminders";
            // 
            // text_search
            // 
            this.text_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search.Location = new System.Drawing.Point(16, 57);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(305, 52);
            this.text_search.TabIndex = 4;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(327, 57);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(103, 52);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // GridView
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridView.Location = new System.Drawing.Point(16, 133);
            this.GridView.Name = "GridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(414, 275);
            this.GridView.TabIndex = 6;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // keep_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(983, 481);
            this.Controls.Add(this.group_box2);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.group_box);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "keep_note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep Note";
            this.group_box.ResumeLayout(false);
            this.group_box.PerformLayout();
            this.group_box2.ResumeLayout(false);
            this.group_box2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_note;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.GroupBox group_box2;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label label2;
    }
}

