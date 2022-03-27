DataBase名：MyProject
Table名：TimerAppRecord
	カラム名 型 付加情報
		No int identity(1,1)←いらんかな～。いまんとこ必要性感じないけど、今後ユニークにする必要が出てきたら使えそうだし入れとこうかな？てきな
		SaveDate DateTime Not Null
		StudingTime Time?←こんな型あるん？テキトーwww
		Comment Varchar(100)
		CommentDate	DateTime←Commentカラムに値が入ったときのみNot Nullを適用したいけど、そんな技できる気がしない！www
		
		