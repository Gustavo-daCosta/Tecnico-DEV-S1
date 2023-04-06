int n3 = 0, n2 = 1;

for (int n1 = 0; n1 <= 500;) {
    n1 = n2 + n3;
    Console.WriteLine(n1);
    n3 = n2;
    n2 = n1;
}
