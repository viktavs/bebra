// 1000 random ints with an average

Random myRan = new Random();
int[] bebra = new bebra{1000};

for (int i = 0; i < bebra.Length; i++) {
  bebra[i] = myRan.Next(1, 100);
}

Console.Writeline(bebra.Average());
