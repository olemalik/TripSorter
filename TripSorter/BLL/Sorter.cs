using System;
using TripSorter.Model;

namespace TripSorter.BLL
{
    public class Sorter
    {
        protected List<Boarding> _boardings = new List<Boarding>();

        public Sorter(List<Boarding> boardings)
        {
            _boardings = boardings;

        }

        public List<Boarding> Bubble()
        {
            List<Boarding> boardings = new List<Boarding>();
            var arr = _boardings;
            Boarding temp = null!;

            for (int j = 0; j <= arr.Count - 2; j++)
            {
                for (int i = 0; i <= arr.Count - 2; i++)
                {
                    if (arr[i].Arrival == arr[i + 1].Departure)
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            foreach (var p in arr)
            {
                boardings.Add(p);
            }
            boardings.Reverse();
            return boardings;
        }
    }
}

