const express= require('express');
const bodyParser=require('body-parser');
const cors=require('cors');

const app=express();
app.use(bodyParser.urlencoded({ extended: false }));
app.use(cors());

var mysql = require('mysql');
 
// create a connection variable with the required details
var con = mysql.createConnection({
  host: "clouddna.ceozdhxehk3z.us-east-2.rds.amazonaws.com", // ip address of server running mysql
  user: "admin", // user name to your mysql database
  password: "ProjectDNA1!", // corresponding password
  database: "ProjectDNA", // use the specified database
});
 
// make to connection to the database.
con.connect(function(err) {
  if (err) throw err;
  // if connection is successful
 console.log('connection successful');
});



app.get('/',(req,res)=>{
  res.json('OK');
})

app.post('/',(req,res)=>{
	var {NewMedicationName,NewMedicationDate} =req.body;
	var records = [[req.body.NewMedicationName,req.body.NewMedicationDate]];
	if(records[0][0]!=null)
	{
		con.query("INSERT into medication (MedicationName,NewMedicationDate) VALUES ?",[records],function(err,res,fields){

			if(err) throw err;

			console.log(res);
		});
	}


})

app.listen(3001,()=>{
  console.log("Port 3001");
})