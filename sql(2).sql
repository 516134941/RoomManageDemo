
create table student(
	id INT NOT NULL AUTO_INCREMENT,
	cno bigint not null,
    user_name varchar(20) not null,
    user_password varchar(20) not null,
    authority int not null,
    primary key(id,cno)
);
insert into student(cno,user_name,user_password,authority) values(201525505003,"程海伦","123456",1);
insert into student(cno,user_name,user_password,authority) values(123456,"学生测试","123456",0);

create table fix_room(
    id INT NOT NULL AUTO_INCREMENT,
    building int not null,
    room_no varchar(20) not null,
    description varchar(100),
    fix_type varchar(20),
    user_name varchar(20) not null,
    primary key(id)
);
insert into fix_room(building,room_no,description,fix_type,user_name) values(11,"S204","厕所漏水","泥工","小明");
insert into fix_room(building,room_no,description,fix_type,user_name) values(10,"S203","床板断了","木工","小红");
insert into fix_room(building,room_no,description,fix_type,user_name) values(14,"w409","电风扇不会转动","电工","李华");

create table room(
    id INT NOT NULL AUTO_INCREMENT,
    building int not null,
    room_no varchar(20) not null,
    ele float,
    primary key(id)
);
insert into room(building,room_no,ele) values(11,"S204",100);
insert into room(building,room_no,ele) values(12,"W444",9.8);

create table water_card(
    id INT NOT NULL AUTO_INCREMENT,
    cno bigint not null,
    money float,
    primary key(id)
);
insert into water_card(cno,money) values(201525505003,13);

create table student_Details(id INT NOT NULL AUTO_INCREMENT,cno bigint not null,user_name varchar(20) not null,    addr varchar(50) not null,    phone bigint not null,    college varchar(50) not null,    class varchar(40) not null,    primary key(id,cno));
insert into student_Details(cno,user_name,addr,phone,college,class) values(201525505010,"小明","广东广州",11111113411,"理电学院","15级XX班");
