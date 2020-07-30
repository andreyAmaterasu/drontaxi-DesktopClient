create table Useraccount (
    email varchar(50) primary key,
    password varchar(50) not null,
    lastname varchar(30) not null,
    firstname varchar(30) not null,
    patronymic varchar(30) not null,
    date_of_birth date,
    gender varchar(20),
    phone_number varchar(30),
    photo varchar(150)
);

insert into Useraccount values ('test@gmail.com', 'pass', 'Иванов', 'Дмитрий', 'Николаевич', '1990-01-01', 'Мужской', '8 999 548 23 10', 'path');

create table Save_useraccount (
    id serial primary key,
    email varchar(50) references Useraccount (email) on delete cascade on update cascade
);

create table Available_roles (
    system_name varchar(50) primary key,
    role_name varchar(50) not null,
    start_date date not null,
    expiration_date date
);

insert into Available_roles values ('manager', 'Менеджер', '2020-01-01');
insert into Available_roles values ('admin', 'Администратор', '2020-01-01');

create table Role_for_user (
    email varchar(50) references Useraccount (email) on delete cascade on update cascade,
    role varchar(50) references Available_roles (system_name) on delete cascade on update cascade,
    primary key (email, role)
);

insert into Role_for_user values ('test@gmail.com', 'manager');
insert into Role_for_user values ('test@gmail.com', 'admin');

create table System_function (
    system_name varchar(50) primary key,
    function_name varchar(50) not null,
    role varchar(50) references Available_roles (system_name) on delete cascade on update cascade
);

insert into System_function values ('user_control', 'Управление пользователями', 'manager');
insert into System_function values ('role_control', 'Управление ролями', 'admin');

create table Master (
    id_master serial primary key,
    lastname varchar(30) not null,
    firstname varchar(30) not null,
    patronymic varchar(30) not null
);

create table Repair_cycle (
    id_repair_cycle serial primary key,
    periodicity_type varchar(30) not null,
    periodicity_value smallint not null
); 

create table Сycle_of_technical_inspections (
    id_technical_inspections serial primary key,
    periodicity_type varchar(30) not null,
    periodicity_value varchar(30) not null
); 

create table Transport (
    id_transport serial primary key,
    brand varchar(30) not null,
    model varchar(30) not null,
    year_of_production smallint not null,
    number_of_registrtion varchar(50) not null,
    date_of_registration date not null,
    writeoff_date date,
    transport_status varchar(50) not null,
    repair_cycle serial references Repair_cycle (id_repair_cycle) on delete cascade on update cascade,
    cycle_of_technical_inspections serial references Сycle_of_technical_inspections (id_technical_inspections) on delete cascade on update cascade
);

create table Transport_photo (
    transport serial primary key references Transport (id_transport) on delete cascade on update cascade,
    photo varchar(150)
);

create table Transport_complectation (
    id_unit serial primary key,
    unit_name varchar(50) not null,
    transport serial references Transport (id_transport) on delete cascade on update cascade
);

create table Additional_attribute (
    id_attribute serial primary key,
    attribute varchar(50) not null,
    attribute_value varchar(50) not null,
    transport serial references Transport (id_transport) on delete cascade on update cascade
);

create table Order_of_user (
    number_of_order serial primary key,
    datetime_of_order timestamp not null,
    customer varchar(50) references Useraccount (email) on delete cascade on update cascade,
    departure_point_address varchar(100) not null,
    destination_address varchar(100) not null,
    status varchar(30) not null,
    transport serial references Transport (id_transport) on delete cascade on update cascade,
    operator varchar(50) references Useraccount (email) on delete cascade on update cascade
);

create table Repairs (
    id_repairs serial primary key,
    type_of_repairs varchar(50) not null,
    date_of_repairs date not null,
    nature_of_failure varchar(50) not null,
    master serial references Master (id_master) on delete cascade on update cascade,
    unit serial references Transport_complectation (id_unit) on delete cascade on update cascade
);

create table Maintenance (
    id_maintenance serial primary key,
    date_of_maintenance date not null,
    inspection_result varchar(30) not null,
    master serial references Master (id_master) on delete cascade on update cascade,
    transport serial references Transport (id_transport) on delete cascade on update cascade
);


