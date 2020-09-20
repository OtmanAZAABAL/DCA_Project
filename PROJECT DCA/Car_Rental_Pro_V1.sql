
create database Car_Rental_Pro_V1
go
use Car_Rental_Pro_V1
go



create table Categorie_Voiture(
	Nom_Categorie varchar(50) primary key  ,
	Nombre_Bagages int NOT NULL,
	Nombre_Perssonne int NOT NULL ,
	Cout_par_Jour float NOT NULL,
	Frois_Retard_par_Heur float NOT NULL 
)


create table Details_Emplacment(
	Emplacement_Id varchar(20) primary key,
	Nom_Emplacment varchar(50),
	Rue varchar(20),
	Ville varchar(20),
	Region varchar(50),
	Zip_code int
)

create table Voiture(
	Numero_Enrg varchar(50)  primary key NOT NULL,
	Nom_Model varchar(50)  NOT NULL  ,
	Marque varchar(50)  NOT NULL,
	Anne_Model varchar(10),
	Kilometrage  int  NOT NULL,
	Photo_Voiture varchar(100),
	Matricule varchar(50) not null unique,
	--primary key
	Nom_Categorie varchar(50)  NOT NULL,
	Emplacement_Id varchar(20)   NOT NULL,
	 link varchar(max),
	--cle etranger
	constraint Fk_Voiture_Categorie_Voiture foreign key (Nom_Categorie) references  Categorie_Voiture(Nom_Categorie),
	constraint Fk_Voiture_Details_Emplacment foreign key (Emplacement_Id) references  Details_Emplacment(Emplacement_Id)

)





create table Assurence_Voiture(
	Cod_Assurences varchar(50) primary key NOT NULL ,
	Nom_Assurences varchar(max) NOT NULL ,
	TYpe_Converture varchar(max) NOT NULL,
	 Cout_par_Jour  float   NOT NULL,

)










create table Client(
	Id_Client varchar(50) primary key NOT NULL,
	Nom_Client varchar(50) NOT NULL ,
	Permis_de_conduire varchar(50) not null,
	Prenom_Client varchar(50) NOT NULL,
	Tel_Client varchar(15)  NULL,
	Email_Client varchar(50)  NULL,
	Ville_Client varchar(50) NOT NULL,
	ZipCod_Client varchar(10)  ,
	Adresse_Client varchar(30),

)





-- make email unique
alter table Client add constraint Uunique_Email_Client unique (Email_Client)

create table Detail_Remise(
	Code_Remise int primary key,
	Nom_Remise varchar(50) unique not null,
	Date_Expiration date not null,
	Percountage_Remise float not null,
)


alter table Detail_Remise add constraint ck_Date_Expiration check (Date_Expiration >= getdate());
alter table Detail_Remise add constraint ck_Percountage_Remise check (Percountage_Remise between 0 and 100);
  



create table Employer(
	Id_Employer int  identity primary key  ,
	Nom_Employer varchar(50) not null  ,
	Prenom_Employer varchar(50)  not null  ,
	Tele_Employer varchar(15)not null  ,
	Email_Employer varchar(50) not null  ,
	Adresse_Employer varchar(50)  not null  ,
	ville varchar(50)   not null    ,
	Designation varchar(50) not null  ,  
	Salaire_Employer float  not null ,
	Date_da_dhesion date  not null ,
)
alter table Employer add constraint Uunique_Email_Employer unique (Email_Employer)
alter table Employer add constraint ck_Date_da_dhesion check (Date_da_dhesion > getdate());




insert into Details_Reservation  values (123,'2020-12-01','2020-02-02',123,12,123,'12341243','12',12,'12','12','12','admin123');



-----------------------------===============================================
--exe4

	
 create    proc VDetails_Reservation (@M int , @dateL datetime , @dateR datetime, @dis bit out )
 as
 begin 
	declare @nb int;
	select @nb = COUNT(*)
	from Details_Reservation 
	where Numero_Enrg = @M
	and ((@dateL>=Date_Location and @dateR<=Date_Retour)
	or (@dateL<=Date_Location and @dateR>=Date_Retour)
	or (@dateL<=Date_Location and @dateR<=Date_Retour and @dateR>Date_Location)
	or (@dateL>Date_Location and @dateL<=Date_Retour and @dateR>=Date_Retour)
	)
	set @dis=0
	if @nb=0 set @dis=1
 end

 
 select * from Voiture
 select * from Details_Reservation
 declare @dis bit;
 exec VDetails_Reservation  1231 , '2021-02-26 19:29:34.000','2021-02-27 19:29:34.000', @dis out
 select @dis
 --------------------------------------------------------------------------------------------===========



create table HistoryReservation(
Reservation_idH int ,
	Date_LocationH datetime ,
	Date_RetourH datetime ,
	MontanteH float ,
	Kilometre_SortieH int  ,
	kilometre_RetourH int  ,
	NoteH text ,

	Cod_AssurencesH varchar(50),
	Code_RemiseH int,
	Id_ClientH  varchar(50)   ,

	Numero_EnrgH varchar(50)  ,
	id_UserH varchar(20)   ,
		[ActionH] varchar(50),
	DateActionH datetime,

);

create table Details_Reservation(
	Reservation_id int primary key,
	Date_Location datetime NOT null,
	Date_Retour datetime NOT null ,
	Montante float NOT NULL ,
	Kilometre_Sortie int  NULL,
	kilometre_Retour int  NULL,
	Note text ,
	--cle primmary
	Cod_Assurences varchar(50),
	Code_Remise int,
	Id_Client  varchar(50)  not null,
	Numero_Enrg varchar(50) not null,
	id_User varchar(20) NOT null ,
	Emplacement_Id  varchar(20) not null ,
--clé étrangere
	constraint Fk_Details_Reservation_Assurence_Voiture foreign key (Cod_Assurences) references  Assurence_Voiture(Cod_Assurences),
	constraint Fk_Details_Reservation_Detail_Remise foreign key (Code_Remise) references  Detail_Remise(Code_Remise),
	constraint Fk_Details_Reservation_Client foreign key (Id_Client) references  Client(Id_Client),
	constraint Fk_Details_Reservation_Voiture foreign key (Numero_Enrg) references  Voiture(Numero_Enrg),
	constraint Fk_Details_Reservation_utilisateur foreign key (id_User) references  utilisateur(id_User),
	constraint Fk_Details_Reservation_Details_Emplacment foreign key (Emplacement_Id) references  Details_Emplacment(Emplacement_Id),
	
) 



alter table Details_Reservation add constraint ck_Date_Location check (datePart(d, Date_Location) >=datePart(d, Date_Location));
alter table Details_Reservation add constraint ck_Date_Location_Date_Retour check (Date_Retour >=Date_Location );


insert into societe values (1,'ismo','vide.png','cc','cc','cc','cc','cc','cc','cc');
create table societe (
 idS  int primary key,
 nom_societe varchar(50)   ,
photo_societe varchar(70) ,
Adress__societe varchar (100),
ville_societe varchar(50),
region_societe varchar(50),
tele varchar(20),
 email varchar(100),
 website varchar(100),
  Code_postal varchar(20),
);



create table Parametres (
 id_P int primary key,
fond_d_ecran varchar(100)
);
insert into Parametres values(1,'vide.png');
	
create table utilisateur(
id_User varchar(20) primary key not null ,
Nom_User varchar(50) not null,
Prenom_User varchar(50) not null,
Email_User varchar(50) not null,
Password_User varchar(50) not null,
Type_User varchar(20) not null,
photo_User varchar(100) not null ,

);

--make_email_Uniuq
insert into utilisateur values ('admin123','aarab ','youssef','aarabayoub70@gmail.com','123','dministarteur','vide.png')

alter table utilisateur add constraint Uunique_Email_User unique (Email_User)












CREATE TABLE HistoryClient(

	Id_Client varchar(50) NOT NULL,
	Nom_Client varchar(50) NOT NULL ,
	Prenom_Client varchar(50) NOT NULL,
	Tel_Client varchar(15)  NULL,
	Email_Client varchar(50)  NULL,
	Ville_Client varchar(50) NOT NULL,
	ZipCod_Client varchar(10)  ,
	Adresse_Client varchar(30),
	[Action] varchar(50),
	DateAction datetime,
	[user] varchar(50)

);




--================================INSERT Categorie_Voiture================
INSERT INTO Categorie_Voiture VALUES('ECONOMY',2,5,30,90);
INSERT INTO Categorie_Voiture VALUES('COMPACT',3,5,32,96);
INSERT INTO Categorie_Voiture VALUES('MID SIZE',3,5,35,105);
INSERT INTO Categorie_Voiture VALUES('STANDARD',3,5,38,114);
INSERT INTO Categorie_Voiture VALUES('FULL SIZE',4,5,40,120);
INSERT INTO Categorie_Voiture VALUES('LUXURY CAR',5,5,75,225);
INSERT INTO Categorie_Voiture VALUES('MID SIZE SUV',2,5,36,108);
INSERT INTO Categorie_Voiture VALUES('STANDARD SUV',3,5,40,12);
INSERT INTO Categorie_Voiture VALUES('FULL SIZE SUV',2,8,60,180);
INSERT INTO Categorie_Voiture VALUES('MINI VAN',5,7,70,210);


--=======================================INSERT Details_Emplacment
select *from Details_Emplacment

INSERT INTO Details_Emplacment VALUES('L1FNIDEQ','KONDISA SOFLA 10 ','Alal fasi','FNIDEQ','Tanger-Tetouan-Al Hoceima',75235);
INSERT INTO Details_Emplacment VALUES('L2Tetouan','marjan 5 b ','Mohamed 6','Tetouan','Tanger-Tetouan-Al Hoceima',90045);
INSERT INTO Details_Emplacment VALUES('L1Tangier','bni makada ','Mohamed 6 ','Tangier','Tanger-Tetouan-Al Hoceima',75261);



--======================================INSERT Assurence_Voiture   



INSERT INTO Assurence_Voiture VALUES('I202','PROTECTION DE RESPONSABILITÉ SUPPLÉMENTAIRE', 'Couvre les dommages causés aux autres',120);
INSERT INTO Assurence_Voiture VALUES('I205','ASSURANCE ACCIDENTS PERSONNELS',' Couvre les frais medicaux pour le conducteur et les passagers',100);


--==================================================================INSERT Voiture  


INSERT INTO Voiture (Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule) VALUES('1234','CIVIC','HONDA',
2014,10000,'ECONOMY','L1FNIDEQ','512A23-75');
INSERT INTO Voiture(Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule) VALUES('4567','FIESTA','FORD',
2015,15000,'ECONOMY','L2Tetouan','21A12341-44');
INSERT INTO Voiture (Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule)VALUES('3245','ACCENT','HYUNDAI',
2014,12356,'ECONOMY','L2Tetouan','213a312-40');
INSERT INTO Voiture (Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule)VALUES('2376','COROLLA','TOYOTA',
2016,5000,'ECONOMY','L1FNIDEQ','A314134-1');
INSERT INTO Voiture (Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule)VALUES('12349','CIVIC','HONDA',
2015,20145,'ECONOMY','L1FNIDEQ','31a241-20');
INSERT INTO Voiture (Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule)VALUES('7625','FOCUS','FORD',
2014,12000,'COMPACT','L1Tangier','1242A23-50');
INSERT INTO Voiture (Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule)VALUES('8202','GOLF','VOLKSWAGAN',
2016,9000,'COMPACT','L2Tetouan','2312A23-75');
INSERT INTO Voiture(Numero_Enrg,Nom_Model,Marque,Anne_Model,Kilometrage,Nom_Categorie,Emplacement_Id,Matricule) VALUES('1890','PRIUS','TOYOTA',
2015,15690,'COMPACT','L1Tangier','593A23-44');

--==================================================================INSERT client 


INSERT INTO Client VALUES('CN812637','AARAB','YOUSSEF','0610214509','donmax512@gmail.com','fnideq','92421','kondisa 12 dr 16 100012','12A7310');
INSERT INTO Client VALUES('CN81923','KHALIDI','SMAIL','062517455','morad512@hmail.com','Casablanca','9830','Casablanca 12  16 9830','1234A12');
INSERT INTO Client VALUES('CN23813','sliman','mhamed','0610216609','mohamedsliman789@gmail.com','Tangier','93100','Tangier 120 16 93100','57B8523');
INSERT INTO Client VALUES('LF228163','HICHOU','HAFSA','052913618','HAFSA512@gmail.com','Marrakesh','LM233','Marrakesh 12 dr 16 LM233','932A52');
INSERT INTO Client VALUES('LF18723','BAKALI','MORAD','062970012','bakali_morad@hmail.com','Sale','9F000','Sale 12  9F000','B623S24');
INSERT INTO Client VALUES('LF9875234','KHALIDI','KARIMN','GFE2135','khalidi@hmail.com','Oujd','9000','Oujd 12 dr 16 9000','354D24512');



--==================================================================INSERT utilisateur 
select * from utilisateur


INSERT INTO utilisateur (id_User,Nom_User,Prenom_User,Email_User,Password_User,Type_User,photo_User) VALUES('admin551','AARAB','YOUSSEF','donmax@hmail.com','1234','user','26-02-2020180021543797729.jpg');

--==================================================================INSERT Employer


insert into Employer values (1,'Aarab','youssef','06120214509','donmax512@gmail.com','kondisa 12 rd 16 ','FNIDEQ','employe',500030,'2020-02-29');



