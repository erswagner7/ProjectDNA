import React, { useEffect } from "react";

import './MyDay.css'

import { Link } from "react-router-dom";

import Chart from "react-apexcharts";

import { useSelector } from "react-redux";

import StatusCard from "../components/status-card/StatusCard";

import Table from "../components/table/Table";

import Badge from "../components/badge/Badge";

import statusCards from "../assets/JsonData/status-card-data.json";

import user_image from '../assets/images/tuat.png';


const MyDayMedication = {
  header: ["Medication id", "User", "Medication", "date", "status", "Report"],
  body: [
    {
      id: "#OD1711",
      user: "john doe",
      date: "5 Mar 2022",
      price: "Donepezil",
      status: "Taken",
      report: "0"
    },
    {
      id: "#OD1712",
      user: "john doe",
      date: "5 Mar 2022",
      price: "Rivastigmine",
      status: "Not Taken",
      report: "1"
    },
    {
      id: "#OD1713",
      user: "john doe",
      date: "6 Mar 2022",
      price: "Donepezil",
      status: "Pending",
      report: "2"
    },
    {
      id: "#OD1714",
      user: "john doe",
      date: "6 Mar 2022",
      price: "Rivastigmine",
      status: "Pending",
      report: "3"
    },
    {
      id: "#OD1715",
      user: "john doe",
      date: "7 Mar 2022",
      price: "Donepezilo",
      status: "Pending",
      report: "4"
    },
    {
      id: "#OD1716",
      user: "john doe",
      date: "7 Mar 2022",
      price: "Rivastigmine",
      status: "Pending",
      report: "5"
    },
  ],
};

const orderStatus = {
  Pending: "warning",
  Taken: "success",
  "Not Taken": "danger",
};

const renderOrderHead = (item, index) => <th key={index}>{item}</th>;
function clickReport() {
  alert("Reported Taken");
}
function changeStatus(item,index) {
  //if ((orderStatus[item.status] == "Not Taken")) {
    //alert(index);
    //MyDayMedication.status = "Taken";
  //}
  /*if ((orderStatus[item.status] == "Not Taken")) {
    item.status[index] = "Taken";
    //MyDayMedication.status = "Taken";
  }*/
}

const renderOrderBody = (item, index) => (
  <tr key={index}>
    <td>{item.id}</td>
    <td>{item.user}</td>
    <td>{item.price}</td>
    <td>{item.date}</td>
    <td>
      <Badge type={orderStatus[item.status]} content={item.status} />
    </td>
    <td>
      <button onClick={changeStatus(item,index)} type="primary">
        Report Taken
      </button>
    </td>
  </tr>
);

const Dashboard = () => {
  const themeReducer = useSelector((state) => state.ThemeReducer.mode);

  return (
    <div>
      <h2 className="page-header">My Medication</h2>
      <div className="row">
        <div className="col-6">
        </div>
        <div className="col-12">
          <div className="card">
            <div className="card_header_mydna">
            <div className="heading_user_image">
                <img className='user_image' src={'/static/media/tuat.c7a4c473.png'} alt="" />
              </div>
            </div>
            <div className="card__body">
              <Table
                headData={MyDayMedication.header}
                renderHead={(item, index) => renderOrderHead(item, index)}
                bodyData={MyDayMedication.body}
                renderBody={(item, index) => renderOrderBody(item, index)}
              />
            </div>
            <div className="card__footer">
              <Link to="/">view all</Link>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Dashboard;
