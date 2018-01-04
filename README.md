### SqlDependency


>使用 SqlDependency() 來監控Table變化觸發Event事件


##### 1.修改Database設定

alter database <dbname> set enable_broker with rollback immediate;


##### 2.SQL的查詢語法欄位不能使用 [*] 的方式


[NG]
select * From [dbo].[alarm_table]

[OK]
select sn,address,create_time From [dbo].[alarm_table]
