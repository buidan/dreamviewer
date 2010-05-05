using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System;
using System.Windows;
namespace Ded.Tutorial.Wpf.CoverFlow.Part5.FlowComponent
{
    public partial class FlowControl : UserControl
    {
        #region Fields
        private int index;
        private readonly List<Cover> coverList = new List<Cover>();
        #endregion
        #region Private stuff
        private void RotateCover(int pos)
        {
            coverList[pos].Animate(index);
        }
        private void UpdateIndex(int newIndex)
        {
            if (index != newIndex)
            {
                int oldIndex = index;
                index = newIndex;
                if (index > oldIndex)
                    for (int i = oldIndex; i <= index; i++)
                        RotateCover(i);
                else
                    for (int i = oldIndex; i >= index; i--)
                        RotateCover(i);
                camera.Position = new Point3D(Cover.CoverStep * index, camera.Position.Y, camera.Position.Z);
            }
        }
        private void viewPort_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var rayMeshResult = (RayMeshGeometry3DHitTestResult)VisualTreeHelper.HitTest(viewPort, e.GetPosition(viewPort));
            if (rayMeshResult != null)
            {
                for (int i = 0; i < coverList.Count; i++)
                {
                    if (coverList[i].Matches(rayMeshResult.MeshHit))
                    {
                        UpdateIndex(i);
                        break;
                    }
                }
            }
        }
        #endregion
        public FlowControl()
        {
            InitializeComponent();
        }


        public void Load(string imagePath, string type)
        {

            wbMain.NavigateToString("<!-- saved from url=(0014)about:internet -->\n\r<html><head><style type=\"text/css\">\n\rbody  {background-color:black}\n\r</style></head><body scroll=\"no\"><iframe src=\"http://tv.phazer.info/phazerbox/9/&css=http://tv.phazer.info/css/v3/livada.pondi.css\" allowtransparency=\"true\" width=\"210\" height=\"250\" frameborder=\"0\" marginwidth=\"0\"  marginheight=\"0\" scrolling=\"no\" style=\"color:black\"></iframe></body></html>");
                
            index = 0;
            coverList.Clear();
            var imageDir = new DirectoryInfo(imagePath);
            int doneImages = 0;
            foreach (FileInfo image in imageDir.GetFiles(type))
            {
                var cover = new Cover(image.FullName, doneImages++);
                coverList.Add(cover);
                visualModel.Children.Add(cover);
            }
            UpdateIndex(coverList.Count / 2);
        }
        public void GoToNext()
        {
            if (index < coverList.Count - 1)
                UpdateIndex(index + 1);
        }
        public void GoToPrevious()
        {
            if (index > 0)
                UpdateIndex(index - 1);
        }

        public string GetCurrImage()
        {
            return coverList[index].GetImage();
        }
    }
}
