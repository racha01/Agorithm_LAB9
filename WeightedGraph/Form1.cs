using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WeightedGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            srcComboBox.Items.AddRange(vertex_list);
            srcComboBox.Text = vertex_list[0];
            descComboBox.Items.AddRange(vertex_list);
            descComboBox.Text = vertex_list[0];
        }

        string[] vertex_list = new string[] { "A", "B", "C", "D", "E", "F" };
        //A   B   C   D   E   F
        int[,] adj_list = new int[,] {  {0, 523, 345, 0, 0, 0},    //A
                                        {523, 0, 200, 548, 0, 0},  //B
                                        {345, 200, 0, 360, 0, 0},  //C
                                        {0, 548, 360, 0, 245, 320},//D
                                        {0, 0, 467, 245, 0, 555},  //E
                                        {0, 0, 0, 320, 555, 0}};   //F
        
        static void DFSTraversal(string[] vertex_list, int[,] adj_list)
        {
            Stack S = new Stack();
            //creating check list
            int[] check_list = new int[vertex_list.Length];
            for (int i = 0; i < check_list.Length; ++i)
                check_list[i] = 0;
            //starting vertex
            int vertex = 0;
            string traversal = vertex_list[vertex];
            //check in list
            check_list[vertex] = 1;
            //row
            int k = 1;
            while (k < adj_list.GetLength(0))
            {
                //column
                for (int j = 0; j < adj_list.GetLength(1); ++j)
                {
                    if ((adj_list[vertex, j] != 0) && (check_list[j] == 0) && (!S.Contains(j)))
                        S.Push(j);
                }
                vertex = (int)S.Pop();
                traversal += " " + vertex_list[vertex];
                check_list[vertex] = 1;
                ++k;
            }
            Console.WriteLine(traversal);
        }


        private void calButton_Click(object sender, EventArgs e)
        {
            int src_index = srcComboBox.SelectedIndex;
            int desc_index = descComboBox.SelectedIndex;
            distanceTextBox.Text = adj_list[src_index, desc_index].ToString();
        }
    }
}
