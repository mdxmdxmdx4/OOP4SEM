create table wasd(
id int primary key,
namee nvarchar(15) not null,
descriptionn nvarchar(30) not null 
);

insert wasd
values (11,'chocolate bar', 'sweet chocolate bar');


insert wasd
values (3,'pan', 'ideal pan for pancakes'), 
(8,'chair', 'very comfort wooden chair'),
(7,'Sprite','throw away the thirst');

select * from wasd;