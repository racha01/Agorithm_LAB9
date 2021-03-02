
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureLib;
using System.Collections;

namespace AdjaceneyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] vertex_list = new string[] { "A", "B", "C", "D", "E", "F", "G", "H"};
            //A  B  C  D  E  F  G  H  I
            /*int[,] adj_list = new int[,] {  {0, 1, 1, 0, 0, 0, 1, 0, 0},//A
                                            {1, 0, 0, 0, 1, 0, 0, 0, 0},//B
                                            {1, 0, 0, 1, 0, 1, 0, 0, 0},//C
                                            {0, 0, 1, 0, 0, 0, 0, 1, 0},//D
                                            {0, 1, 0, 0, 0, 0, 1, 0, 0},//E
                                            {0, 0, 1, 0, 0, 0, 1, 1, 0},//F
                                            {1, 0, 0, 0, 1, 1, 0, 0, 0},//G
                                            {0, 0, 0, 1, 0, 1, 0, 0, 0}};//H*/
                                          //{0, 0, 0, 0, 0, 0, 0, 0, 0}};//I
            int[,] adj_list = new int[,] {  {0, 1, 0, 0, 1},
                                            {1, 0, 0, 1, 0},
                                            {0, 0, 0, 1, 1},
                                            {0, 1, 1, 0, 0},
                                            {1, 0, 1, 0, 0} };
            Console.Write("Input source city (A, B, C, D, E) : ");
            string src = Console.ReadLine().ToUpper();
            int src_index = FindIndex(vertex_list, src);
            //Console.WriteLine(FindIndex(vertex_list, src));
            Console.Write("Input destination city (A, B, C, D, E) : ");
            string desc = Console.ReadLine().ToUpper();
            //Console.WriteLine(FindIndex(vertex_list, desc));
            int desc_index = FindIndex(vertex_list, desc);
            //Console.WriteLine(adj_list[src_index, desc_index]);
            if (adj_list[src_index, desc_index] != 0)
                //Console.WriteLine((adj_list[src_index, desc_index]));
                Console.WriteLine("You can go from {0} to {1}", vertex_list[src_index], vertex_list[desc_index]);
            else
                Console.WriteLine("You cannot go from {0} to {1}", vertex_list[src_index], vertex_list[desc_index]);
            DFSTraversal(vertex_list, adj_list);
            BFSTraversal(vertex_list, adj_list);
        }
        static int FindIndex(string[] vertex_list, string data) 
        {
            for (int i = 0; i < vertex_list.Length; i++)
            {
                //Console.WriteLine(data);
                //Console.WriteLine(vertex_list[i]);
                if (data == vertex_list[i]) //
                {
                    //Console.WriteLine(data);
                    Console.WriteLine(vertex_list[i]);
                    return i;
                }
                   
            }
            return -1;
        }
        static void DFSTraversal(string[] vertex_list, int[,] adj_list)
        {
            Stack S = new Stack();

            int[] check_list = new int[vertex_list.Length];
            for (int i = 0; i < check_list.Length; ++i)
            {
                check_list[i] = 0;
                //Console.WriteLine(check_list[i]);
            }
            //Console.WriteLine();
                
            int vertex = 0;
            string traversal = vertex_list[vertex];
            
            check_list[vertex] = 1;
            //Console.WriteLine(check_list[vertex]);
            
            int k = 1;
            while (k < adj_list.GetLength(0))
            {
                
                for (int j = 0; j < adj_list.GetLength(1); ++j)
                {
                    //Console.WriteLine(!S.Contains(j));
                    //Console.WriteLine(vertex);
                    //Console.WriteLine(j);
                    //Console.WriteLine(adj_list[4, 2]);
                    //Console.WriteLine(adj_list[vertex, j]);
                    //Console.WriteLine(check_list[j]);
                    /*Console.Write(check_list[0]);
                    Console.WriteLine();
                    Console.Write(check_list[1]);
                    Console.WriteLine();*/
                    /*Console.Write(check_list[2]);
                    Console.WriteLine();
                    Console.Write(check_list[3]);
                    Console.WriteLine();
                    Console.Write(check_list[4]);
                    Console.WriteLine();
                    //S.Contains(j);*/
                    if ((adj_list[vertex, j] != 0) && (check_list[j] == 0) && (!S.Contains(j)))
                        S.Push(j);
                    //Console.WriteLine(check_list[j]);
                    
                }
                //Console.WriteLine();
                vertex = (int)S.Pop();
                traversal += " " + vertex_list[vertex];
                check_list[vertex] = 1;
                ++k;   
            }
            Console.WriteLine(traversal);
            //int l = -1;
            //Console.WriteLine(vertex);
            /*while (l < traversal.Length)
            {
                l++;
                Console.Write (traversal);
            }*/
        }
        static void BFSTraversal(string[] vertex_list, int[,] adj_list)
        {
            Queue Q = new Queue();

            int[] check_list = new int[vertex_list.Length];
            for (int i = 0; i < check_list.Length; ++i)
                check_list[i] = 0;

            int vertex = 0;
            string traversal = vertex_list[vertex];

            check_list[vertex] = 1;

            int k = 1;
            while (k < adj_list.GetLength(0))
            {

                for (int j = 0; j < adj_list.GetLength(1); ++j)
                {
                    if ((adj_list[vertex, j] != 0) && (check_list[j] == 0) && (!Q.Contains(j)))
                        Q.Enqueue(j);
                }
                vertex = (int)Q.Dequeue();
                traversal += " " + vertex_list[vertex];
                check_list[vertex] = 1;
                ++k;
            }
            Console.WriteLine(traversal);
            
        }

    }
    
}
