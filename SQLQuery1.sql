use [D:\BTLWEB\WEBAPPLICATION_CAYCANHONLINE\WEBAPPLICATION_CAYCANHONLINE\APP_DATA\COMMENTS.MDF]
create table tblhoidap
(
id int identity (1,1) not null,
firstname nvarchar (10) not null,
lastname nvarchar (10) not null,
email nvarchar (100) not null,
subj nvarchar (100) not null,
messenger nvarchar (max) not null,
)

create proc xoahd
@id int
as
begin
delete tblhoidap
where id=@id
end
create proc inserthd
@firstname nvarchar(10),
@lastname nvarchar (10),
@email nvarchar (100),
@subj nvarchar (100),
@messenger nvarchar (max)
as
begin
insert into tblhoidap(firstname, lastname,email,subj,messenger)
values (@firstname, @lastname,@email,@subj,@messenger)
end
create proc  layds
as
begin
select *from tblhoidap
end
