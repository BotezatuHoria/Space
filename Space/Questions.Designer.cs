
namespace Space
{
    partial class Questions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label responseALabel;
            System.Windows.Forms.Label responseBLabel;
            System.Windows.Forms.Label responseCLabel;
            System.Windows.Forms.Label responseDLabel;
            this.questionsDataSet = new Space.QuestionsDataSet();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new Space.QuestionsDataSetTableAdapters.QuestionsTableAdapter();
            this.tableAdapterManager = new Space.QuestionsDataSetTableAdapters.TableAdapterManager();
            this.questionLabel1 = new System.Windows.Forms.Label();
            this.responseALabel1 = new System.Windows.Forms.Label();
            this.responseBLabel1 = new System.Windows.Forms.Label();
            this.responseCLabel1 = new System.Windows.Forms.Label();
            this.responseDLabel1 = new System.Windows.Forms.Label();
            responseALabel = new System.Windows.Forms.Label();
            responseBLabel = new System.Windows.Forms.Label();
            responseCLabel = new System.Windows.Forms.Label();
            responseDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataSet
            // 
            this.questionsDataSet.DataSetName = "QuestionsDataSet";
            this.questionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.questionsDataSet;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuestionsTableAdapter = this.questionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Space.QuestionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // questionLabel1
            // 
            this.questionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Question", true));
            this.questionLabel1.Location = new System.Drawing.Point(112, 53);
            this.questionLabel1.Name = "questionLabel1";
            this.questionLabel1.Size = new System.Drawing.Size(619, 51);
            this.questionLabel1.TabIndex = 4;
            this.questionLabel1.Text = "label1";
            // 
            // responseALabel
            // 
            responseALabel.AutoSize = true;
            responseALabel.Location = new System.Drawing.Point(37, 140);
            responseALabel.Name = "responseALabel";
            responseALabel.Size = new System.Drawing.Size(17, 13);
            responseALabel.TabIndex = 5;
            responseALabel.Text = "A:";
            responseALabel.Click += new System.EventHandler(this.responseALabel_Click);
            // 
            // responseALabel1
            // 
            this.responseALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ResponseA", true));
            this.responseALabel1.Location = new System.Drawing.Point(112, 140);
            this.responseALabel1.Name = "responseALabel1";
            this.responseALabel1.Size = new System.Drawing.Size(619, 23);
            this.responseALabel1.TabIndex = 6;
            this.responseALabel1.Text = "label1";
            // 
            // responseBLabel
            // 
            responseBLabel.AutoSize = true;
            responseBLabel.Location = new System.Drawing.Point(37, 163);
            responseBLabel.Name = "responseBLabel";
            responseBLabel.Size = new System.Drawing.Size(17, 13);
            responseBLabel.TabIndex = 7;
            responseBLabel.Text = "B:";
            // 
            // responseBLabel1
            // 
            this.responseBLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ResponseB", true));
            this.responseBLabel1.Location = new System.Drawing.Point(112, 163);
            this.responseBLabel1.Name = "responseBLabel1";
            this.responseBLabel1.Size = new System.Drawing.Size(619, 23);
            this.responseBLabel1.TabIndex = 8;
            this.responseBLabel1.Text = "label1";
            // 
            // responseCLabel
            // 
            responseCLabel.AutoSize = true;
            responseCLabel.Location = new System.Drawing.Point(37, 186);
            responseCLabel.Name = "responseCLabel";
            responseCLabel.Size = new System.Drawing.Size(17, 13);
            responseCLabel.TabIndex = 9;
            responseCLabel.Text = "C:";
            // 
            // responseCLabel1
            // 
            this.responseCLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ResponseC", true));
            this.responseCLabel1.Location = new System.Drawing.Point(112, 186);
            this.responseCLabel1.Name = "responseCLabel1";
            this.responseCLabel1.Size = new System.Drawing.Size(619, 23);
            this.responseCLabel1.TabIndex = 10;
            this.responseCLabel1.Text = "label1";
            // 
            // responseDLabel
            // 
            responseDLabel.AutoSize = true;
            responseDLabel.Location = new System.Drawing.Point(37, 209);
            responseDLabel.Name = "responseDLabel";
            responseDLabel.Size = new System.Drawing.Size(18, 13);
            responseDLabel.TabIndex = 11;
            responseDLabel.Text = "D:";
            // 
            // responseDLabel1
            // 
            this.responseDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ResponseD", true));
            this.responseDLabel1.Location = new System.Drawing.Point(112, 209);
            this.responseDLabel1.Name = "responseDLabel1";
            this.responseDLabel1.Size = new System.Drawing.Size(619, 23);
            this.responseDLabel1.TabIndex = 12;
            this.responseDLabel1.Text = "label1";
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionLabel1);
            this.Controls.Add(responseALabel);
            this.Controls.Add(this.responseALabel1);
            this.Controls.Add(responseBLabel);
            this.Controls.Add(this.responseBLabel1);
            this.Controls.Add(responseCLabel);
            this.Controls.Add(this.responseCLabel1);
            this.Controls.Add(responseDLabel);
            this.Controls.Add(this.responseDLabel1);
            this.Name = "Questions";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuestionsDataSet questionsDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private QuestionsDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private QuestionsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label questionLabel1;
        private System.Windows.Forms.Label responseALabel1;
        private System.Windows.Forms.Label responseBLabel1;
        private System.Windows.Forms.Label responseCLabel1;
        private System.Windows.Forms.Label responseDLabel1;
    }
}