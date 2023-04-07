using System;
using System.Collections.Generic;

public class Node
{
    public int Deger;
    public Node Next;

    public Node(int deger)
    {
        Deger = deger;
        Next = null;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Palindrom olan "head1" bağlı liste örneği 
        Node head1 = new Node(1);
        head1.Next = new Node(2);
        head1.Next.Next = new Node(3);
        head1.Next.Next.Next = new Node(2);
        head1.Next.Next.Next.Next = new Node(1);

        bool polindrom1 = BagliListePalindrom(head1);
        Console.WriteLine(polindrom1 ? "Head1 bağlı listesi palindromdur.\n" : "Head1 bağlı listesi palindrom değildir.\n");

        // Palindrom olmayan "head2" bağlı liste örneği 
        Node head2 = new Node(1);
        head2.Next = new Node(2);
        head2.Next.Next = new Node(3);
        head2.Next.Next.Next = new Node(4);

        bool polindrom2 = BagliListePalindrom(head2);
        Console.WriteLine(polindrom2 ? "Head2 bağlı listesi palindromdur." : "Head2 bağlı listesi palindrom değildir.");

        Console.ReadLine();
    }

    public static bool BagliListePalindrom(Node head)
    {
        if (head == null) // Başlangıçta boş bir liste verildiğinde
            return false;

        Stack<Node> stack = new Stack<Node>();
        Node yavas = head;
        Node hizli = head;

        while (hizli != null && hizli.Next != null)
        {
            stack.Push(yavas);
            yavas = yavas.Next;
            hizli = hizli.Next.Next;
        }

        // Liste tek sayıda elemana sahipse, ortadaki elemanı atlayalım
        if (hizli != null)
            yavas = yavas.Next;

        while (yavas != null)
        {
            Node top = stack.Pop();
            if (top.Deger != yavas.Deger)
                return false;

            yavas = yavas.Next;
        }

        return true;
    }
}
