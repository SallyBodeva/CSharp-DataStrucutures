using P01_TreesExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Serialization;

public class Program
{
    static void Main()
    {
        Tree15();
    }
    public static void Tree1()
    {
        Tree<int> tree = new Tree<int>(
            50,
                new Tree<int>(30)
            );
        Console.WriteLine(tree.PrintS());
    }
    public static void Tree2()
    {
        Tree<string> t = new Tree<string>(
            "50",
                new Tree<string>("L",
                    new Tree<string>("^"))
            );
        PrintTree(t);
    }

    public static void Tree3()
    {
        Tree<string> t = new Tree<string>(
            "50",
                new Tree<string>("L",
                    new Tree<string>("^",
                        new Tree<string>("1"),
                        new Tree<string>("2")
                    )
               )
            );
        PrintTree(t);
    }
    public static void Tree4()
    {
        Tree<int> t = new Tree<int>(
            50,
                new Tree<int>(30),
                new Tree<int>(40),
                new Tree<int>(50),
                new Tree<int>(60)
            );
        PrintTree(t);
    }
    public static void Tree5()
    {
        Tree<char> t = new Tree<char>(
            'P',
                   new Tree<char>('Q',
                        new Tree<char>('A')
                   ),
                   new Tree<char>('R',
                        new Tree<char>('B'),
                        new Tree<char>('C')
                   ),
                   new Tree<char>('S',
                        new Tree<char>('D')
                   )
            );
        PrintTree(t);
    }
    public static void Tree6()
    {
        Tree<int> t = new Tree<int>(
            90,
                new Tree<int>(50,
                    new Tree<int>(20,
                        new Tree<int>(5),
                         new Tree<int>(25)
                    ),
                new Tree<int>(75,
                        new Tree<int>(66),
                        new Tree<int>(80)
                    )
                  ),
                new Tree<int>(150,
                    new Tree<int>(96,
                        new Tree<int>(92),
                         new Tree<int>(111)
                    ),
                    new Tree<int>(175,
                        new Tree<int>(166),
                        new Tree<int>(200)
                    )
                )
            );
        PrintTree(t);
    }
    public static void Tree7()
    {
        Tree<int> t = new Tree<int>(
            13,
                new Tree<int>(3,
                        new Tree<int>(1,
                            new Tree<int>(2)
                        ),
                        new Tree<int>(4,
                            new Tree<int>(12,
                                new Tree<int>(10,
                                    new Tree<int>(5,
                                        new Tree<int>(8,
                                            new Tree<int>(7,
                                                new Tree<int>(6)
                                            ),
                                            new Tree<int>(9)
                                        )
                                    ),
                                    new Tree<int>(11)
                               )
                            )
                        )
                    ),
                    new Tree<int>(14,
                        new Tree<int>(18)
                    )
            );
        PrintTree(t);
    }
    public static void Tree8()
    {
        Tree<string> t = new Tree<string>(
               "John",
                    new Tree<string>("Steve",
                        new Tree<string>("Lee"),
                        new Tree<string>("Bob"),
                        new Tree<string>("Ella")
                    ),
                    new Tree<string>("Rohan",
                        new Tree<string>("Sal"),
                        new Tree<string>("Emma",
                            new Tree<string>("Tom",
                                new Tree<string>("Bill")
                            ),
                            new Tree<string>("Raj")
                        )
                    )
            );
        PrintTree(t);
    }
    public static void Tree9()
    {
        Tree<char> t = new Tree<char>(
            'O',
                new Tree<char>('M',
                    new Tree<char>('L',
                        new Tree<char>('+'),
                        new Tree<char>('*')
                    )
                ),
                new Tree<char>('L',
                    new Tree<char>('&'),
                    new Tree<char>('|'),
                    new Tree<char>('!')
                ),
                new Tree<char>('B'),
                new Tree<char>('S',
                    new Tree<char>('R',
                        new Tree<char>('-'),
                        new Tree<char>('/')
                    )
                )
            );
        PrintTree(t);
    }
    public static void Tree10()
    {
        Tree<char> t = new Tree<char>(
            'O',
                new Tree<char>('M',
                    new Tree<char>('L',
                        new Tree<char>('+'),
                         new Tree<char>('*')
                    )
                ),
                new Tree<char>('L'),
                new Tree<char>('B'),
                new Tree<char>('S',
                    new Tree<char>('R',
                        new Tree<char>('-'),
                        new Tree<char>('/')
                    )
                )
            );
        PrintTree(t);
    }
    public static void Tree11()
    {
        Tree<char> t = new Tree<char>(
            'O',
                new Tree<char>('M',
                    new Tree<char>('L',
                        new Tree<char>('+'),
                        new Tree<char>('*',
                            new Tree<char>('M'),
                            new Tree<char>('R',
                                new Tree<char>('-'),
                                new Tree<char>('/')
                            ),
                            new Tree<char>('-')
                        )
                    )
                ),
                new Tree<char>('L',
                    new Tree<char>('&'),
                    new Tree<char>('|')
                ),
                new Tree<char>('B',
                    new Tree<char>('!',
                        new Tree<char>('R',
                            new Tree<char>('/',
                                new Tree<char>('R',
                                    new Tree<char>('-'),
                                    new Tree<char>('/')
                                )
                            )
                        )
                    )
                ),
                new Tree<char>('S',
                    new Tree<char>('R',
                        new Tree<char>('-',
                            new Tree<char>('R',
                                new Tree<char>('-'),
                                new Tree<char>('/')
                            )
                        ),
                        new Tree<char>('/')
                    )
                ),
                new Tree<char>('R',
                    new Tree<char>('-'),
                     new Tree<char>('/',
                        new Tree<char>('R',
                            new Tree<char>('-'),
                            new Tree<char>('/')
                        )
                     )
                )
            );
        PrintTree(t);
    }
    public static void Tree12()
    {
        Tree<char> t = new Tree<char>(
            'P',
                new Tree<char>('Q',
                    new Tree<char>('A')
                ),
                new Tree<char>('R',
                    new Tree<char>('B'),
                    new Tree<char>('C')
                ),
                new Tree<char>('S',
                    new Tree<char>('D')
                )
            );
        PrintTree(t);
    }
    public static void Tree13()
    {
        Tree<char> t = new Tree<char>('A',
                new Tree<char>('B',
                    new Tree<char>('E'),
                    new Tree<char>('F')
                ),
                new Tree<char>('C',
                    new Tree<char>('G',
                        new Tree<char>('J'),
                        new Tree<char>('K')
                    )
                ),
                new Tree<char>('D',
                    new Tree<char>('H'),
                    new Tree<char>('I')
                )
                );
        PrintTree(t);
    }
    public static void Tree14()
    {
        Tree<int> t = new Tree<int>(
            7,
                new Tree<int>(19,
                    new Tree<int>(1),
                    new Tree<int>(12),
                    new Tree<int>(31)
                ),
                new Tree<int>(21),
                new Tree<int>(14,
                    new Tree<int>(23),
                    new Tree<int>(6)
               )
            );
        PrintTree(t);
    }
    public static void Tree15()
    {
        Tree<string> t = new Tree<string>(
            "50",
                new Tree<string>("30"),
                new Tree<string>("40",
                    new Tree<string>(","),
                    new Tree<string>("!")
                ),
                new Tree<string>("50"),
                new Tree<string>("60",
                    new Tree<string>("A"),
                    new Tree<string>("B")
                )
            );
        PrintTree(t);
    }
    private static void PrintTree(Tree<string> t)
    {
        Console.WriteLine(t.PrintS());
        List<string> LineBFS = t.OrderBFS().ToList();
        Console.WriteLine(string.Join(" ", LineBFS));
        List<string> LineDFS = t.OrderDFS().ToList();
        Console.WriteLine(string.Join(" ", LineDFS));
    }
    private static void PrintTree(Tree<int> t)
    {
        Console.WriteLine(t.PrintS());
        List<int> LineBFS = t.OrderBFS().ToList();
        Console.WriteLine(string.Join(" ", LineBFS));
        List<int> LineDFS = t.OrderDFS().ToList();
        Console.WriteLine(string.Join(" ", LineDFS));
    }
    private static void PrintTree(Tree<char> t)
    {
        Console.WriteLine(t.PrintS());
        List<char> LineBFS = t.OrderBFS().ToList();
        Console.WriteLine(string.Join(" ", LineBFS));
        List<char> LineDFS = t.OrderDFS().ToList();
        Console.WriteLine(string.Join(" ", LineDFS));
    }
}

