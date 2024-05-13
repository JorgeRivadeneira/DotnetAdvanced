DateTime? date = null;
DateTime date2 = date ?? DateTime.Today; //Null coallisence
DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

//if(date != null )
//    date2 = date.GetValueOrDefault();
//else
//    date2 = DateTime.Today;

Console.WriteLine(date2);
