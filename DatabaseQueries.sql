use [MyATM]
SET ANSI_PADDING ON
GO

-- Table Locations

CREATE TABLE [dbo].[Locations](
	[Name] [varchar](50) NOT NULL,
	[Latitude] [numeric](18, 6) NOT NULL,
	[Longitude] [numeric](18, 6) NOT NULL,
	[Description] [varchar](300) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO Locations
SELECT 'Mumbai', 18.9647, 72.8258, 'Mumbai formerly Bombay, is the capital city of the Indian state of Maharashtra.'
UNION ALL
SELECT 'Pune', 18.5236, 73.8478, 'Pune is the seventh largest metropolis in India, the second largest in the state of Maharashtra after Mumbai.'
UNION ALL
SELECT 'Alibaug', 18.6414, 72.8722, 'Alibaug is a coastal town and a municipal council in Raigad District in the Konkan region of Maharashtra, India.'


--  ATM Table
drop table ATM;

CREATE TABLE [dbo].[ATM](
	[Name] [varchar](50) NOT NULL,
	[BankName] [varchar](300) NULL,
	[State] [varchar](300) NULL,
	[Latitude] [numeric](18, 6) NOT NULL,
	[Longitude] [numeric](18, 6) NOT NULL,
	[Description] [varchar](300) NULL,
);



insert into ATM values ('Česká spořitelna, a.s. - ATM','CESKA SPORITELNA A.S.','Prague','50.084040','14.416620','Česká spořitelna');
insert into ATM values ('Česká spořitelna, a.s. - ATM','CESKA SPORITELNA A.S.','Prague','50.086100','14.419550','Česká spořitelna');
insert into ATM values ('Česká spořitelna, a.s. - ATM','CESKA SPORITELNA A.S.','Prague','50.075730','14.420050','Česká spořitelna');
insert into ATM values ('Česká spořitelna, a.s. - ATM','CESKA SPORITELNA A.S.','Prague','50.092360','14.411710','Česká spořitelna');
insert into ATM values ('Česká spořitelna, a.s. - ATM','CESKA SPORITELNA A.S.','Prague','50.082650','14.41	8890','Česká spořitelna');

insert into ATM values ('Air Bank ATM','Air Bank','Prague','50.082650','14.418890','Česká spořitelna');

insert into ATM values ('BODY INTERNACESKETIONAL BROKERS ','BODY INTERNACESKETIONAL BROKERS A.S.','Prague','50.082650','14.418890','BODY INTERNACESKETIONAL BROKERS A.S.a');





use MyATM
SELECT * FROM ATM a WHERE a.State ='asdad' OR a.BankName ='asdsad' order by Name;

-- Bank Table

drop table Bank;

CREATE TABLE [dbo].[Bank](
	[Name] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
	[StateCode] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[CountryCode] [varchar](50) NOT NULL,
	[Description] [varchar](300) NULL,
) 


insert into Bank values ('Air Bank','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('42 FINANCIAL SERVICES','PRAHA','','Czech Republic','CZE','Bank Name');



insert into Bank values ('A AND CE GLOBAL FINANCE, A.S.','BRNO','','Czech Republic','CZE','Bank Name');
insert into Bank values ('AKRO INVESTICNLSPOLECNOST, A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('ARCELORMITTAL OSTRAVA A.S.','OSTRAVA','','Czech Republic','CZE','Bank Name');
insert into Bank values ('ARTESA, SPORITELNI DRUZSTVO','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('ATLANTA SAFE, A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('ATLANTIK ASSET MANAGEMENT INVESTICNI SPOLECNOST,A.S','BRNO','','Czech Republic','CZE','Bank Name');
insert into Bank values ('ATLANTIK FINANCNI TRHY, A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('AXA INVESTICNI SPOLECNOST A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('BH SECURITIES A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('BODY INTERNACESKETIONAL BROKERS A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('BROKERJET  SPORITELNY, A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('BURZOVNI SPOLECNOST PRO KAPITALOVY TRH, A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('CAPITAL PARTNERS A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('CESKA BANKA A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('CESKA NARODNI BANKA','PRAGUE','','Czech Republic','CZE','Bank Name');
insert into Bank values ('CESKA SPORITELNA A.S.','PRAGUE','','Czech Republic','CZE','Bank Name');







use MyATM;
select Name from dbo.Bank where State='PRAGUE';





