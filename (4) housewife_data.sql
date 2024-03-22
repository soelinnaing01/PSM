USE housewife;

insert into descriptions(description) values(N'salary');
insert into descriptions(description) VALUES(N'poor money');
insert into descriptions(description) VALUES(N'OverTime');
insert into descriptions(description) VALUES(N'annuity');
insert into descriptions(description) VALUES(N'allowance');
insert into descriptions(description) VALUES(N'bonus');
insert into descriptions(description) VALUES(N'Part Time Job');
insert into descriptions(description) VALUES(N'accomplishment');
insert into descriptions(description) values(N'Earn Money');
insert into descriptions(description) values(N'ကြက်သွန်နီဝယ်');
insert into descriptions(description) values(N'မီတာခ');
insert into descriptions(description) values(N'ရေခွန်');
insert into descriptions(description) values(N'အိမ်လခ');
insert into descriptions(description) values(N'အဝတ်အစားဝယ်');
insert into descriptions(description) values(N'ဆန်ဝယ်');
insert into descriptions(description) values(N'မုန့်ဝယ်');
insert into descriptions(description) values(N'ဆီဝယ်');

insert into cash_flow(text) values('cash');
insert into cash_flow(text) values('wave pay');
insert into cash_flow(text) values('K pay');
insert into cash_flow(text) values('Banking');

insert into from_to_flow(text) values(N'MyJob');
insert into from_to_flow(text) values(N'Gallary company');
insert into from_to_flow(text) values(N'WeShare SoftwareHouse');
insert into from_to_flow(text) values(N'Facebook Page');
insert into from_to_flow(text) values(N'Youtube');
insert into from_to_flow(text) values(N'KhinWintWah');
insert into from_to_flow(text) values(N'My Mother');
insert into from_to_flow(text) values(N'ဖြိုးကုန်စုံဆိုင်');
insert into from_to_flow(text) values(N'မိုး ကုန်စုံဆိုင်');
insert into from_to_flow(text) values(N'Apple Store');

INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (1,1,1,500000,1,'2019-01-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (2,1,1,500000,1,'2019-02-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (3,1,1,20000,1,'2019-03-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (4,1,1,10000,1,'2019-04-06');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (5,1,1,5000,1,'2019-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (6,1,1,40000,1,'2019-06-08');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (6,1,1,25000,1,'2019-07-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (7,2,1,80000,1,'2019-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (8,5,1,5000,1,'2019-12-10');

INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (1,1,1,500000,1,'2020-01-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (1,1,1,500000,1,'2020-02-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (2,1,1,20000,1,'2020-03-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (3,1,1,10000,1,'2020-04-06');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (4,1,1,5000,1,'2020-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (5,1,1,40000,1,'2020-06-08');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (6,1,1,25000,1,'2020-07-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (7,2,1,80000,1,'2020-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (8,5,1,5000,1,'2020-12-10');

INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (1,1,1,500000,1,'2021-01-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (2,1,1,500000,1,'2021-02-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (2,1,1,20000,1,'2021-03-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (3,1,1,10000,1,'2021-04-06');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (4,1,1,5000,1,'2021-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (5,1,1,40000,1,'2021-06-08');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (6,1,1,25000,1,'2021-07-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (7,2,1,80000,1,'2021-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (8,5,1,5000,1,'2021-12-10');

INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (1,1,1,500000,1,'2022-01-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (2,1,1,500000,1,'2022-02-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (3,1,1,20000,1,'2022-03-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (3,1,1,10000,1,'2022-04-06');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (4,1,1,5000,1,'2022-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (5,1,1,40000,1,'2022-06-08');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (6,1,1,25000,1,'2022-07-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (7,2,1,80000,1,'2022-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (8,5,1,5000,1,'2022-12-10');

INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (1,1,1,500000,1,'2023-01-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (2,1,1,500000,1,'2023-02-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (3,1,1,20000,1,'2023-03-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (4,1,1,10000,1,'2023-04-06');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (4,1,1,5000,1,'2023-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (5,1,1,40000,1,'2023-06-08');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (6,1,1,25000,1,'2023-07-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (7,2,1,80000,1,'2023-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (8,5,1,5000,1,'2023-12-10');

INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (1,1,1,500000,1,'2024-01-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (2,1,1,500000,1,'2024-02-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (3,1,1,40000,1,'2024-03-05');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (4,1,1,10000,1,'2024-04-06');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (5,1,1,5000,1,'2024-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (5,1,1,40000,1,'2024-06-08');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (6,1,1,25000,1,'2024-07-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (7,2,1,80000,1,'2024-05-07');
INSERT INTO incomes (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (8,5,1,5000,1,'2024-12-10');

INSERT INTO expenditure_budgets(month,amount)
VALUES('2019-01-4',10000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2019-02-5',20000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2019-03-6',50000);

INSERT INTO expenditure_budgets(month,amount)
VALUES('2020-04-7',40000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2020-05-5',20000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2020-06-7',50000);

INSERT INTO expenditure_budgets(month,amount)
VALUES('2021-06-7',40000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2021-07-5',20000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2021-08-6',50000);

INSERT INTO expenditure_budgets(month,amount)
VALUES('2022-07-7',40000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2022-08-5',20000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2022-09-6',100000);

INSERT INTO expenditure_budgets(month,amount)
VALUES('2023-01-10',30000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2023-03-5',40000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2023-05-6',10000);

INSERT INTO expenditure_budgets(month,amount)
VALUES('2024-01-10',500000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2024-03-10',10000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2024-10-10',10000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2024-11-5',20000);
INSERT INTO expenditure_budgets(month,amount)
VALUES('2024-12-6',80000);

INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (9,6,1,500000,1,'2019-01-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (10,7,1,500000,1,'2019-02-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,8,1,20000,1,'2019-03-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (12,9,1,10000,1,'2019-04-06');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (13,6,1,5000,1,'2019-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (14,7,1,40000,1,'2019-06-08');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (14,10,1,25000,1,'2019-07-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (15,10,1,80000,1,'2019-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (16,10,1,5000,1,'2019-12-10');

INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (9,6,1,500000,1,'2020-01-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (9,6,1,500000,1,'2020-02-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (10,6,1,20000,1,'2020-03-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,7,1,10000,1,'2020-04-06');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (12,8,1,5000,1,'2020-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (13,9,1,40000,1,'2020-06-08');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (14,10,1,25000,1,'2020-07-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (15,10,1,80000,1,'2020-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (16,7,1,5000,1,'2020-12-10');

INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (9,6,1,500000,1,'2021-01-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (10,7,1,500000,1,'2021-02-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (10,7,1,20000,1,'2021-03-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,7,1,10000,1,'2021-04-06');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (12,8,1,5000,1,'2021-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (13,9,1,40000,1,'2021-06-08');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (14,10,1,25000,1,'2021-07-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (15,7,1,80000,1,'2021-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (16,10,1,5000,1,'2021-12-10');

INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (9,6,1,500000,1,'2022-01-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (10,7,1,500000,1,'2022-02-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,8,1,20000,1,'2022-03-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,8,1,10000,1,'2022-04-06');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (12,8,1,5000,1,'2022-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (13,9,1,40000,1,'2022-06-08');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (14,10,1,25000,1,'2022-07-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (15,9,1,80000,1,'2022-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (16,7,1,5000,1,'2022-12-10');

INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (9,6,1,500000,1,'2023-01-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (10,7,1,500000,1,'2023-02-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,8,1,20000,1,'2023-03-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (12,9,1,10000,1,'2023-04-06');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (12,9,1,5000,1,'2023-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (13,9,1,40000,1,'2023-06-08');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (14,10,1,25000,1,'2023-07-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (15,6,1,80000,1,'2023-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (16,9,1,5000,1,'2023-12-10');

INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (9,6,1,500000,1,'2024-01-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (10,7,1,500000,1,'2024-02-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,8,1,20000,1,'2024-03-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (11,9,1,20000,1,'2024-03-05');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (12,9,1,10000,1,'2024-04-06');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (13,10,1,5000,1,'2024-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (13,10,1,40000,1,'2024-06-08');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (14,6,1,25000,1,'2024-07-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (15,6,1,80000,1,'2024-05-07');
INSERT INTO expenses (description_id,from_to_flow_id,user_id,amount,cash_flow_id,date) 
VALUES (16,8,1,5000,1,'2024-12-10');