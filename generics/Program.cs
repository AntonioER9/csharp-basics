

// var numbers = new MyList<int>(5);
// var names = new MyList<string>(5);

// numbers.Add(1);
// numbers.Add(2);
// numbers.Add(3);
// numbers.Add(4);
// numbers.Add(5);
// numbers.Add(6);

// Console.WriteLine(numbers.GetContent());

// public class MyList<T>
// {
//   private List<T> _list;
//   private int _limit;

//   public MyList(int limit) {
//     _limit = limit;
//     _list = new List<T>();
//   }

//   public void Add(T element)
//   {
//     if (_list.Count < _limit)
//     {
//       _list.Add(element);
//     }
//   }

//   public string GetContent()
//   {
//     string content = "";
//     foreach (var element in _list){
//       content += element+",";
//     }
//     return content;
//   }
// }