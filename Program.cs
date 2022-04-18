
for (string i = "0"; i !="1";){
Console.WriteLine("請輸入姓名");
string name = Console.ReadLine();
Console.WriteLine("請選擇性別1.男2.女3.其他性別");

string sex = Console.ReadLine();
switch(sex){
case "1":
sex = "男";
break;
case "2":
sex = "女";
break;
case "3":
sex = "其他性別";
break;
}


Console.WriteLine("請輸入出生年月日");
string bir = Console.ReadLine();
Console.WriteLine("請輸入學號");
string id = Console.ReadLine();
Console.WriteLine(name);
Console.WriteLine(sex);
Console.WriteLine(bir);
Console.WriteLine(id);
Console.WriteLine("資料正確請輸入1,否則輸入2");
i = Console.ReadLine();
if(i == "1"){
    Console.WriteLine("已完成資料建置");
}else{
    Console.WriteLine("請重新開始寫資料");
}



};


