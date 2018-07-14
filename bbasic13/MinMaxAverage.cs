/*
Min, Max, and Average

Given any array x, say [1, 5, 10, -2], create an algorithm that prints the maximum number in the array, 
the minimum value in the array, and the average of the values in the array.


          double[] array = {19, -31, 88,-44, 7, 1, 5, 10, -2};
          double Max = 0;
          double Min = 0;
          double Avg = 0;
          double Sum = 0;

          for (int i = 0; i < array.Length; i++)
          {
              if (array[i] > Max)
              {
                  Max = array[i] ;
                  Sum = Sum + array[i];
              }
              else if (array[i] < Min)
              {
                  Min = array[i];
                  Sum = Sum + array[i];
              }
          }
          Console.WriteLine($"The largest number in the array is: {Max}");
          Console.WriteLine($"The smallest number in the array is: {Min}");

          Avg = Sum/array.Length;
          Console.WriteLine($"The average of the array is: {Avg}");















 */