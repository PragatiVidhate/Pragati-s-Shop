Create table Category(
Category_id int not null,
Category_Name varchar(100) not null,
Total_Products int,
primary key(Category_id));

Insert into Category (Category_id,Category_Name,Total_Products) values (1,'book',10);
select * from Category;
Insert into Aproduct(Aproduct_id,Aproduct_Name,Category_id,Aprice) values(1,'Sunder',1,20);
select * from Product;
update Category set Category_id =1,Category_Name ='b',Total_Products =100;
Delete From Product where Category_id=1;
Delete from Product where Category_id in(Select Category_id from Category where Category_Name='Book');

Create table Aproduct(
Aproduct_id int not null,
Aproduct_Name varchar(100) not null,
Category_id int not null,
Aprice int not null,
primary key(Aproduct_id),
foreign key(Category_id) References Category
     on delete cascade
	 on update cascade
);
Select * from Aproduct;
Insert into Aproduct(Aproduct_id,Aproduct_Name,Category_id,Aprice) values(1,'Sunder',2,20);
update Aproduct set Aproduct_Name='s',Aprice =12 Where Aproduct_id=2;