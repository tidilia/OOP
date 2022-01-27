using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using laba07.Shape;

namespace laba07.Observer
{
    class TreeViewObserver: CObserver
    {
        TreeView tree;
        ShapeStorage st;
        public TreeViewObserver(TreeView treeView)
        {
            tree = treeView;
        }
        public override void onSubjectChanged(CSubject who)
        {
            tree.Nodes.Clear();
            st = (ShapeStorage)who;
            for(int i = 0; i < st.GetCount(); i++)
            {
                tree.Nodes.Add(makeNode(st.GetShape(i)));
            }
        }

        public TreeNode makeNode(ShapeCl shape)
        {
            TreeNode retValue = new TreeNode();
            if (shape.IsSelected) tree.SelectedNode = retValue;
            if (shape.isA("Circle"))
            {
                retValue.Text = "Circle, id: " + shape.Id.ToString();
                return retValue;
            }
            if (shape.isA("Triangle"))
            {
                retValue.Text = "Triangle, id: " + shape.Id.ToString();
                return retValue;
            }
            if (shape.isA("Rectangle"))
            {
                retValue.Text = "Rectangle, id: " + shape.Id.ToString();
                return retValue;
            }
            if (shape.isA("Group"))
            {
                Group current = (Group)shape;
                for(int i = current.GetCount() - 1; i >= 0; --i)
                {
                    retValue.Nodes.Add(makeNode(current.GetShape(i)));
                }
                retValue.Text = "Group, id: " + current.Id;
                if (shape.IsSelected) tree.SelectedNode = retValue;
                return retValue;
            }
            return retValue;
        }
    }
}
