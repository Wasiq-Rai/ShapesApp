namespace ShapesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private RichTextBox richTextBox1;
        private ImageList imageList1;
        private PictureBox Line;
        private PictureBox Circle;
        private PictureBox Square;
        private PictureBox Triangle;
        private PictureBox Rectangle;
        private ListBox listBoxShapes;
        private ListBox infoList;
        private Button info_button;
        private Button draw_button;
        private Button refresh_button;
        private Label RefreshStatusLabel;
    }
}
