namespace CompGeo6DurovMA
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadGraph = new System.Windows.Forms.Button();
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelAddWeight = new System.Windows.Forms.Label();
            this.labelAddNode = new System.Windows.Forms.Label();
            this.textBoxAddNode = new System.Windows.Forms.TextBox();
            this.groupBoxChecks = new System.Windows.Forms.GroupBox();
            this.radioButtonDelEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonAddEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonMoveNode = new System.Windows.Forms.RadioButton();
            this.radioButtonDelNode = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNode = new System.Windows.Forms.RadioButton();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.groupBoxChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadGraph
            // 
            this.buttonLoadGraph.Location = new System.Drawing.Point(12, 244);
            this.buttonLoadGraph.Name = "buttonLoadGraph";
            this.buttonLoadGraph.Size = new System.Drawing.Size(133, 23);
            this.buttonLoadGraph.TabIndex = 25;
            this.buttonLoadGraph.Text = "Загрузить граф";
            this.buttonLoadGraph.UseVisualStyleBackColor = true;
            this.buttonLoadGraph.Click += new System.EventHandler(this.buttonLoadGraph_Click);
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(12, 215);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(133, 23);
            this.buttonSaveGraph.TabIndex = 24;
            this.buttonSaveGraph.Text = "Сохранить граф";
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(104, 189);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(41, 20);
            this.textBoxWeight.TabIndex = 23;
            // 
            // labelAddWeight
            // 
            this.labelAddWeight.AutoSize = true;
            this.labelAddWeight.Location = new System.Drawing.Point(33, 192);
            this.labelAddWeight.Name = "labelAddWeight";
            this.labelAddWeight.Size = new System.Drawing.Size(65, 13);
            this.labelAddWeight.TabIndex = 22;
            this.labelAddWeight.Text = "Вес ребра: ";
            // 
            // labelAddNode
            // 
            this.labelAddNode.AutoSize = true;
            this.labelAddNode.Location = new System.Drawing.Point(9, 166);
            this.labelAddNode.Name = "labelAddNode";
            this.labelAddNode.Size = new System.Drawing.Size(89, 13);
            this.labelAddNode.TabIndex = 21;
            this.labelAddNode.Text = "Название узла: ";
            // 
            // textBoxAddNode
            // 
            this.textBoxAddNode.Location = new System.Drawing.Point(104, 163);
            this.textBoxAddNode.Name = "textBoxAddNode";
            this.textBoxAddNode.Size = new System.Drawing.Size(41, 20);
            this.textBoxAddNode.TabIndex = 20;
            // 
            // groupBoxChecks
            // 
            this.groupBoxChecks.Controls.Add(this.radioButtonDelEdge);
            this.groupBoxChecks.Controls.Add(this.radioButtonAddEdge);
            this.groupBoxChecks.Controls.Add(this.radioButtonMoveNode);
            this.groupBoxChecks.Controls.Add(this.radioButtonDelNode);
            this.groupBoxChecks.Controls.Add(this.radioButtonAddNode);
            this.groupBoxChecks.Location = new System.Drawing.Point(12, 12);
            this.groupBoxChecks.Name = "groupBoxChecks";
            this.groupBoxChecks.Size = new System.Drawing.Size(133, 140);
            this.groupBoxChecks.TabIndex = 19;
            this.groupBoxChecks.TabStop = false;
            this.groupBoxChecks.Text = "Режим";
            // 
            // radioButtonDelEdge
            // 
            this.radioButtonDelEdge.AutoSize = true;
            this.radioButtonDelEdge.Location = new System.Drawing.Point(7, 116);
            this.radioButtonDelEdge.Name = "radioButtonDelEdge";
            this.radioButtonDelEdge.Size = new System.Drawing.Size(101, 17);
            this.radioButtonDelEdge.TabIndex = 4;
            this.radioButtonDelEdge.TabStop = true;
            this.radioButtonDelEdge.Text = "Удалить ребро";
            this.radioButtonDelEdge.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddEdge
            // 
            this.radioButtonAddEdge.AutoSize = true;
            this.radioButtonAddEdge.Location = new System.Drawing.Point(7, 92);
            this.radioButtonAddEdge.Name = "radioButtonAddEdge";
            this.radioButtonAddEdge.Size = new System.Drawing.Size(108, 17);
            this.radioButtonAddEdge.TabIndex = 3;
            this.radioButtonAddEdge.TabStop = true;
            this.radioButtonAddEdge.Text = "Добавить ребро";
            this.radioButtonAddEdge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoveNode
            // 
            this.radioButtonMoveNode.AutoSize = true;
            this.radioButtonMoveNode.Location = new System.Drawing.Point(7, 68);
            this.radioButtonMoveNode.Name = "radioButtonMoveNode";
            this.radioButtonMoveNode.Size = new System.Drawing.Size(119, 17);
            this.radioButtonMoveNode.TabIndex = 2;
            this.radioButtonMoveNode.TabStop = true;
            this.radioButtonMoveNode.Text = "Переместить узел";
            this.radioButtonMoveNode.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelNode
            // 
            this.radioButtonDelNode.AutoSize = true;
            this.radioButtonDelNode.Location = new System.Drawing.Point(7, 44);
            this.radioButtonDelNode.Name = "radioButtonDelNode";
            this.radioButtonDelNode.Size = new System.Drawing.Size(94, 17);
            this.radioButtonDelNode.TabIndex = 1;
            this.radioButtonDelNode.TabStop = true;
            this.radioButtonDelNode.Text = "Удалить узел";
            this.radioButtonDelNode.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddNode
            // 
            this.radioButtonAddNode.AutoSize = true;
            this.radioButtonAddNode.Location = new System.Drawing.Point(7, 21);
            this.radioButtonAddNode.Name = "radioButtonAddNode";
            this.radioButtonAddNode.Size = new System.Drawing.Size(101, 17);
            this.radioButtonAddNode.TabIndex = 0;
            this.radioButtonAddNode.TabStop = true;
            this.radioButtonAddNode.Text = "Добавить узел";
            this.radioButtonAddNode.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(151, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1272, 581);
            this.pictureBoxMain.TabIndex = 29;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1427, 699);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonLoadGraph);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelAddWeight);
            this.Controls.Add(this.labelAddNode);
            this.Controls.Add(this.textBoxAddNode);
            this.Controls.Add(this.groupBoxChecks);
            this.Name = "FormMain";
            this.Text = "Семантические сети";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxChecks.ResumeLayout(false);
            this.groupBoxChecks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoadGraph;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelAddWeight;
        private System.Windows.Forms.Label labelAddNode;
        private System.Windows.Forms.TextBox textBoxAddNode;
        private System.Windows.Forms.GroupBox groupBoxChecks;
        private System.Windows.Forms.RadioButton radioButtonDelEdge;
        private System.Windows.Forms.RadioButton radioButtonAddEdge;
        private System.Windows.Forms.RadioButton radioButtonMoveNode;
        private System.Windows.Forms.RadioButton radioButtonDelNode;
        private System.Windows.Forms.RadioButton radioButtonAddNode;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}

