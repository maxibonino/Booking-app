USE master 
GO 

IF EXISTS(SELECT * FROM sys.databases WHERE name='Booking') 
BEGIN 
	DROP DATABASE Booking 
END 
GO 

CREATE DATABASE Booking 
GO 

USE Booking 
GO

CREATE TABLE [Kategoria] (
	Id_kat integer NOT NULL,
	Metrazh integer NOT NULL,
	Kol_vo_komnat integer NOT NULL,
  CONSTRAINT [PK_KATEGORIA] PRIMARY KEY CLUSTERED
  (
  [Id_kat] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Harakteristica] (
	Id_har integer NOT NULL,
	kol_vo_komnat integer NOT NULL,
	metrazh integer NOT NULL,
	Id_kv integer NOT NULL,
  CONSTRAINT [PK_HARAKTERISTICA] PRIMARY KEY CLUSTERED
  (
  [Id_har] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Klient] (
	Id_kl integer NOT NULL,
	Lastname nvarchar(150) NOT NULL,
	Firstname nvarchar(150) NOT NULL,
	Patronymic nvarchar(150) NOT NULL,
	DateBirth nvarchar(150) NOT NULL,
	Passport integer NOT NULL,
	Telephone integer NOT NULL,
	Email integer NOT NULL,
	Id_kv integer NOT NULL,
  CONSTRAINT [PK_KLIENT] PRIMARY KEY CLUSTERED
  (
  [Id_kl] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Oplata] (
	Id_opl integer NOT NULL,
	Sposob_opl nvarchar(150) NOT NULL,
	Id_kl integer NOT NULL,
  CONSTRAINT [PK_OPLATA] PRIMARY KEY CLUSTERED
  (
  [Id_opl] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Broni] (
	Id_bron integer NOT NULL,
	Vid_broni nvarchar(150) NOT NULL,
	Id_opl integer NOT NULL,
  CONSTRAINT [PK_BRONI] PRIMARY KEY CLUSTERED
  (
  [Id_bron] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Personal_uslov] (
	Id_usl integer NOT NULL,
	Vid_usl nvarchar(150) NOT NULL,
	Id_kl integer NOT NULL,
  CONSTRAINT [PK_PERSONAL_USLOV] PRIMARY KEY CLUSTERED
  (
  [Id_usl] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Kvartira] (
	Id_kv integer NOT NULL,
	Otdelka nvarchar(150) NOT NULL,
	Stoimost integer NOT NULL,
	Etazh integer NOT NULL,
	Korpus nvarchar(150),
	Zh_kompleks nvarchar(150),
  CONSTRAINT [PK_KVARTIRA] PRIMARY KEY CLUSTERED
  (
  [Id_kv] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Korpus] (
	Id_korp integer NOT NULL,
	Kol_vo_etazh integer NOT NULL,
	Kol_vo_kv integer NOT NULL,
	Id_kv integer NOT NULL,
	Id_type integer NOT NULL,
	Id_srok integer NOT NULL,
	Id_kompl integer NOT NULL,
  CONSTRAINT [PK_KORPUS] PRIMARY KEY CLUSTERED
  (
  [Id_korp] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Tip_doma] (
	Id_type integer NOT NULL,
	Vid_otdelki nvarchar(150) NOT NULL,
  CONSTRAINT [PK_TIP_DOMA] PRIMARY KEY CLUSTERED
  (
  [Id_type] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Srok_sdachi] (
	Id_srok integer NOT NULL,
	Ranniy nvarchar(150) NOT NULL,
	Pozdniy nvarchar(150) NOT NULL,
  CONSTRAINT [PK_SROK_SDACHI] PRIMARY KEY CLUSTERED
  (
  [Id_srok] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Zh_komplex] (
	Id_kompl integer NOT NULL,
	Raspolozhenie nvarchar(150) NOT NULL,
  CONSTRAINT [PK_ZH_KOMPLEX] PRIMARY KEY CLUSTERED
  (
  [Id_kompl] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Sotrudnik] (
	Id_sot integer NOT NULL,
	Lastname nvarchar(150) NOT NULL,
	Firstname nvarchar(150) NOT NULL,
	Patronymic nvarchar(150) NOT NULL,
	Dolzhnost nvarchar(150) NOT NULL,
	Telephone integer NOT NULL,
	Id_kompl integer NOT NULL,
	Id_polz integer NOT NULL,
  CONSTRAINT [PK_SOTRUDNIK] PRIMARY KEY CLUSTERED
  (
  [Id_sot] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Polzovatel] (
	Id_polz integer NOT NULL,
	Login nvarchar(150) NOT NULL,
	Password nvarchar(150) NOT NULL,
	Tip_polzovatel nvarchar(150) NOT NULL,
  CONSTRAINT [PK_POLZOVATEL] PRIMARY KEY CLUSTERED
  (
  [Id_polz] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Harakteristica] WITH CHECK ADD CONSTRAINT [Harakteristica_fk0] FOREIGN KEY ([Id_kv]) REFERENCES [Kvartira]([Id_kv])
ON UPDATE CASCADE
GO
ALTER TABLE [Harakteristica] CHECK CONSTRAINT [Harakteristica_fk0]
GO

ALTER TABLE [Klient] WITH CHECK ADD CONSTRAINT [Klient_fk0] FOREIGN KEY ([Id_kv]) REFERENCES [Kvartira]([Id_kv])
ON UPDATE CASCADE
GO
ALTER TABLE [Klient] CHECK CONSTRAINT [Klient_fk0]
GO

ALTER TABLE [Oplata] WITH CHECK ADD CONSTRAINT [Oplata_fk0] FOREIGN KEY ([Id_kl]) REFERENCES [Klient]([Id_kl])
ON UPDATE CASCADE
GO
ALTER TABLE [Oplata] CHECK CONSTRAINT [Oplata_fk0]
GO

ALTER TABLE [Broni] WITH CHECK ADD CONSTRAINT [Broni_fk0] FOREIGN KEY ([Id_opl]) REFERENCES [Oplata]([Id_opl])
ON UPDATE CASCADE
GO
ALTER TABLE [Broni] CHECK CONSTRAINT [Broni_fk0]
GO

ALTER TABLE [Personal_uslov] WITH CHECK ADD CONSTRAINT [Personal_uslov_fk0] FOREIGN KEY ([Id_kl]) REFERENCES [Klient]([Id_kl])
ON UPDATE CASCADE
GO
ALTER TABLE [Personal_uslov] CHECK CONSTRAINT [Personal_uslov_fk0]
GO


ALTER TABLE [Korpus] WITH CHECK ADD CONSTRAINT [Korpus_fk0] FOREIGN KEY ([Id_kv]) REFERENCES [Kvartira]([Id_kv])
ON UPDATE CASCADE
GO
ALTER TABLE [Korpus] CHECK CONSTRAINT [Korpus_fk0]
GO
ALTER TABLE [Korpus] WITH CHECK ADD CONSTRAINT [Korpus_fk1] FOREIGN KEY ([Id_type]) REFERENCES [Tip_doma]([Id_type])
ON UPDATE CASCADE
GO
ALTER TABLE [Korpus] CHECK CONSTRAINT [Korpus_fk1]
GO
ALTER TABLE [Korpus] WITH CHECK ADD CONSTRAINT [Korpus_fk2] FOREIGN KEY ([Id_srok]) REFERENCES [Srok_sdachi]([Id_srok])
ON UPDATE CASCADE
GO
ALTER TABLE [Korpus] CHECK CONSTRAINT [Korpus_fk2]
GO
ALTER TABLE [Korpus] WITH CHECK ADD CONSTRAINT [Korpus_fk3] FOREIGN KEY ([Id_kompl]) REFERENCES [Zh_komplex]([Id_kompl])
ON UPDATE CASCADE
GO
ALTER TABLE [Korpus] CHECK CONSTRAINT [Korpus_fk3]
GO




ALTER TABLE [Sotrudnik] WITH CHECK ADD CONSTRAINT [Sotrudnik_fk0] FOREIGN KEY ([Id_kompl]) REFERENCES [Zh_komplex]([Id_kompl])
ON UPDATE CASCADE
GO
ALTER TABLE [Sotrudnik] CHECK CONSTRAINT [Sotrudnik_fk0]
GO
ALTER TABLE [Sotrudnik] WITH CHECK ADD CONSTRAINT [Sotrudnik_fk1] FOREIGN KEY ([Id_polz]) REFERENCES [Polzovatel]([Id_polz])
ON UPDATE CASCADE
GO
ALTER TABLE [Sotrudnik] CHECK CONSTRAINT [Sotrudnik_fk1]
GO
