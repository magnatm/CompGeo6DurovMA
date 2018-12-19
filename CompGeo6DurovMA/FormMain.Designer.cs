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
            this.labelAddNode = new System.Windows.Forms.Label();
            this.textBoxAddNode = new System.Windows.Forms.TextBox();
            this.groupBoxChecks = new System.Windows.Forms.GroupBox();
            this.radioButtonDelEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonAddEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonMoveNode = new System.Windows.Forms.RadioButton();
            this.radioButtonDelNode = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNode = new System.Windows.Forms.RadioButton();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonNodeColor = new System.Windows.Forms.Button();
            this.buttonNodeFill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.buttonEdgeColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonArrowColor = new System.Windows.Forms.Button();
            this.groupBoxNode = new System.Windows.Forms.GroupBox();
            this.radioButtonSquareNode = new System.Windows.Forms.RadioButton();
            this.radioButtonRoundNode = new System.Windows.Forms.RadioButton();
            this.groupBoxChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBoxNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadGraph
            // 
            this.buttonLoadGraph.Location = new System.Drawing.Point(12, 322);
            this.buttonLoadGraph.Name = "buttonLoadGraph";
            this.buttonLoadGraph.Size = new System.Drawing.Size(151, 23);
            this.buttonLoadGraph.TabIndex = 25;
            this.buttonLoadGraph.Text = "Загрузить граф";
            this.buttonLoadGraph.UseVisualStyleBackColor = true;
            this.buttonLoadGraph.Click += new System.EventHandler(this.buttonLoadGraph_Click);
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(12, 293);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(151, 23);
            this.buttonSaveGraph.TabIndex = 24;
            this.buttonSaveGraph.Text = "Сохранить граф";
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // labelAddNode
            // 
            this.labelAddNode.AutoSize = true;
            this.labelAddNode.Location = new System.Drawing.Point(0, 261);
            this.labelAddNode.Name = "labelAddNode";
            this.labelAddNode.Size = new System.Drawing.Size(86, 13);
            this.labelAddNode.TabIndex = 21;
            this.labelAddNode.Text = "Название узла:";
            // 
            // textBoxAddNode
            // 
            this.textBoxAddNode.Location = new System.Drawing.Point(88, 258);
            this.textBoxAddNode.Name = "textBoxAddNode";
            this.textBoxAddNode.Size = new System.Drawing.Size(75, 20);
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
            this.groupBoxChecks.Size = new System.Drawing.Size(151, 140);
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
            this.pictureBoxMain.Location = new System.Drawing.Point(169, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1100, 592);
            this.pictureBoxMain.TabIndex = 29;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            // 
            // buttonNodeColor
            // 
            this.buttonNodeColor.BackColor = System.Drawing.Color.Red;
            this.buttonNodeColor.Location = new System.Drawing.Point(112, 361);
            this.buttonNodeColor.Name = "buttonNodeColor";
            this.buttonNodeColor.Size = new System.Drawing.Size(51, 23);
            this.buttonNodeColor.TabIndex = 30;
            this.buttonNodeColor.UseVisualStyleBackColor = false;
            this.buttonNodeColor.Click += new System.EventHandler(this.buttonNodeColor_Click);
            // 
            // buttonNodeFill
            // 
            this.buttonNodeFill.BackColor = System.Drawing.Color.Pink;
            this.buttonNodeFill.Location = new System.Drawing.Point(112, 386);
            this.buttonNodeFill.Name = "buttonNodeFill";
            this.buttonNodeFill.Size = new System.Drawing.Size(51, 23);
            this.buttonNodeFill.TabIndex = 31;
            this.buttonNodeFill.UseVisualStyleBackColor = false;
            this.buttonNodeFill.Click += new System.EventHandler(this.buttonNodeFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Цвет границы узла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Фон узла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Цвет текста узла";
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonFontColor.Location = new System.Drawing.Point(112, 412);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(51, 23);
            this.buttonFontColor.TabIndex = 35;
            this.buttonFontColor.UseVisualStyleBackColor = false;
            this.buttonFontColor.Click += new System.EventHandler(this.buttonFontColor_Click);
            // 
            // buttonEdgeColor
            // 
            this.buttonEdgeColor.BackColor = System.Drawing.Color.HotPink;
            this.buttonEdgeColor.Location = new System.Drawing.Point(112, 441);
            this.buttonEdgeColor.Name = "buttonEdgeColor";
            this.buttonEdgeColor.Size = new System.Drawing.Size(51, 23);
            this.buttonEdgeColor.TabIndex = 36;
            this.buttonEdgeColor.UseVisualStyleBackColor = false;
            this.buttonEdgeColor.Click += new System.EventHandler(this.buttonEdgeColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Цвет ребра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Цвет стрелки";
            // 
            // buttonArrowColor
            // 
            this.buttonArrowColor.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonArrowColor.Location = new System.Drawing.Point(112, 469);
            this.buttonArrowColor.Name = "buttonArrowColor";
            this.buttonArrowColor.Size = new System.Drawing.Size(51, 23);
            this.buttonArrowColor.TabIndex = 38;
            this.buttonArrowColor.UseVisualStyleBackColor = false;
            this.buttonArrowColor.Click += new System.EventHandler(this.buttonArrowColor_Click);
            // 
            // groupBoxNode
            // 
            this.groupBoxNode.Controls.Add(this.radioButtonRoundNode);
            this.groupBoxNode.Controls.Add(this.radioButtonSquareNode);
            this.groupBoxNode.Location = new System.Drawing.Point(12, 159);
            this.groupBoxNode.Name = "groupBoxNode";
            this.groupBoxNode.Size = new System.Drawing.Size(151, 67);
            this.groupBoxNode.TabIndex = 40;
            this.groupBoxNode.TabStop = false;
            this.groupBoxNode.Text = "Форма узла";
            // 
            // radioButtonSquareNode
            // 
            this.radioButtonSquareNode.AutoSize = true;
            this.radioButtonSquareNode.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSquareNode.Name = "radioButtonSquareNode";
            this.radioButtonSquareNode.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSquareNode.TabIndex = 0;
            this.radioButtonSquareNode.TabStop = true;
            this.radioButtonSquareNode.Text = "Прямоугольник";
            this.radioButtonSquareNode.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoundNode
            // 
            this.radioButtonRoundNode.AutoSize = true;
            this.radioButtonRoundNode.Location = new System.Drawing.Point(7, 19);
            this.radioButtonRoundNode.Name = "radioButtonRoundNode";
            this.radioButtonRoundNode.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRoundNode.TabIndex = 1;
            this.radioButtonRoundNode.TabStop = true;
            this.radioButtonRoundNode.Text = "Эллипс";
            this.radioButtonRoundNode.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.groupBoxNode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonArrowColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEdgeColor);
            this.Controls.Add(this.buttonFontColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNodeFill);
            this.Controls.Add(this.buttonNodeColor);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonLoadGraph);
            this.Controls.Add(this.buttonSaveGraph);
            this.Controls.Add(this.labelAddNode);
            this.Controls.Add(this.textBoxAddNode);
            this.Controls.Add(this.groupBoxChecks);
            this.Name = "FormMain";
            this.Text = "Семантические сети";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxChecks.ResumeLayout(false);
            this.groupBoxChecks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBoxNode.ResumeLayout(false);
            this.groupBoxNode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoadGraph;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.Label labelAddNode;
        private System.Windows.Forms.TextBox textBoxAddNode;
        private System.Windows.Forms.GroupBox groupBoxChecks;
        private System.Windows.Forms.RadioButton radioButtonDelEdge;
        private System.Windows.Forms.RadioButton radioButtonAddEdge;
        private System.Windows.Forms.RadioButton radioButtonMoveNode;
        private System.Windows.Forms.RadioButton radioButtonDelNode;
        private System.Windows.Forms.RadioButton radioButtonAddNode;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonNodeColor;
        private System.Windows.Forms.Button buttonNodeFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFontColor;
        private System.Windows.Forms.Button buttonEdgeColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonArrowColor;
        private System.Windows.Forms.GroupBox groupBoxNode;
        private System.Windows.Forms.RadioButton radioButtonRoundNode;
        private System.Windows.Forms.RadioButton radioButtonSquareNode;
    }
}

