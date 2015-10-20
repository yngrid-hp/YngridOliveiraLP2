insert into Salesman values('S1', 'Smith', 20, 'London');
insert into Salesman values('S2', 'Jones', 10, 'Paris');
insert into Salesman values('S3', 'Blake', 30, 'Paris');
insert into Salesman values('S4', 'Clark', 20, 'London');
insert into Salesman values('S5', 'Adams', 30, 'Athens');

insert into Pieces values('P1', 'Nut', 'Red', 12, 'London');
insert into Pieces values('P2', 'Bolt', 'Green', 17, 'Paris');
insert into Pieces values('P3', 'Screw', 'Blue', 17, 'Rome');
insert into Pieces values('P4', 'Screw', 'Red', 14, 'London');
insert into Pieces values('P5', 'Cam', 'Blue', 12, 'Paris');
insert into Pieces values('P6', 'Cog', 'Red', 19, 'London');

insert into SalesmanPieces values('S1', 'P1', 300);
insert into SalesmanPieces values('S1', 'P2', 200);
insert into SalesmanPieces values('S1', 'P3', 400);
insert into SalesmanPieces values('S1', 'P4', 200);
insert into SalesmanPieces values('S1', 'P5', 100);
insert into SalesmanPieces values('S1', 'P6', 100);
insert into SalesmanPieces values('S2', 'P1', 300);
insert into SalesmanPieces values('S2', 'P2', 400);
insert into SalesmanPieces values('S3', 'P2', 200);
insert into SalesmanPieces(scod, pcod) values('S4', 'P2');
insert into SalesmanPieces values('S4', 'P4', 300);
insert into SalesmanPieces values('S4', 'P5', 400);