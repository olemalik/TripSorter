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
        /*  public void sort()
          {
          // Get first and last trip
          setFirstLastBoarding();

              // Now we pair boardings
              for (int i = 0, max = _boardings.Count - 1; i < max ; i++) {
                  // Foreach trip we test for the arrival city and the departure city
                  int idx = 0;
                  foreach (var trip in _boardings) {
                      idx++;
                      // echo $this->boardings[$i]['Arrival'];
                      // echo $trip['Departure'];
                      if (_boardings[i].Arrival == trip.Departure)
                      {
                      int nextIdx = i + 1;
                      var tempBoarding = _boardings[nextIdx];
                      _boardings[nextIdx] = trip;
                      _boardings[idx] = tempBoarding;
                      }
                  }
              }
          }

          private void setFirstLastBoarding()
          {
              List<Boarding> boardings = new List<Boarding>();


              bool isLastBoarding = true;
              bool hasPrevBoarding = false;

              for (int i = 0, max = _boardings.Count; i < max ; i++)
              {
                  // Foreach trip we test for the arrival city and the departure city
                  foreach (var trip in _boardings)
                  {
                      // If current trip's departure is another trip arrivel, then we have a previous trip
                      if (_boardings[i].Departure == trip.Arrival)
                      {
                       hasPrevBoarding = true;
                      }
                      // If current trip's arrival is another trip departure, then it is not the last trip
                      else if(_boardings[i].Arrival ==  trip.Departure)
                      {
                      isLastBoarding = false;
                      }
                  }

                  // Assign the last and the first trip
                  if (!hasPrevBoarding)
                  {
                      boardings.Add(_boardings[i]);
                     var ss = _boardings[i];
                      _boardings.Remove(ss);
                      _boardings.Insert(0, ss);//.Add()
                      // It is the first trip so we put it on the top
                      // array_unshift(_boardings, _boardings[i]);
                      // unset(_boardings[i]);
                  }
                  else if(isLastBoarding)
                  {
                      var ss = _boardings[i];
                      _boardings.Remove(ss);
                      boardings.Add(ss);
                     // _boardings.Insert((_boardings.Count - 1), _boardings[i]);
                      // It is the last trip so we put it at the bottom
                      // array_push(_boardings, _boardings[i]);
                      //unset(_boardings[i]);
                  }
              }

          // We regenerate indexes
          //_boardings = array_merge(_boardings);
          }

          public List<Boarding> getBoardings()
          {
              return _boardings;
          }*/


    }
    
}

