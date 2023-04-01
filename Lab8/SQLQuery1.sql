create procedure Find_bill_by_type @wallet nvarchar(4)
as
begin
select PersonalBill.Id, PersonalBill.FIO,Owner.birthDate, Owner.wallet from 
PersonalBill inner join Owner on PersonalBill.FIO = Owner.FIO
where wallet = @wallet;
end;

exec Find_bill_by_type @wallet = 'USD';

select * from Owner;

begin tran
insert Owner
values ('Кушнарёв Роман Витальевич', CONVERT(datetime,'2003-12-12'), '375298887766', 'EUR', 'AB6790521');
commit tran;


select * from PersonalBill;
select * from Owner;
