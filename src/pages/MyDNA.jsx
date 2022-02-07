import React, { useEffect } from "react";

import { Link } from "react-router-dom";

import { useSelector } from "react-redux";

import './MyDNA.css'

import Table from "../components/table/Table";

const MyProfile = {
  header: [
    "User id",
    "Username",
    "First Name",
    "Last Name",
    "Phone #",
    "Address",
  ],
  body: [
    {
      id: "#0001",
      username: "johnD123",
      firstname: "John",
      lastname: "Doe",
      phone: "440-555-5555",
      address: "123 notreal st",
    },
  ],
};
const MyConnections = {
    header: [
      "User id",
      "Username",
      "First Name",
      "Last Name",
      "Phone #",
      "Address",
    ],
    body: [
      {
        id: "#0341",
        username: "janeC225",
        firstname: "Jane",
        lastname: "Cae",
        phone: "440-666-6666",
        address: "1233 notreal st apt 1",
      },
    ],
  };
const renderOrderHead = (item, index) => <th key={index}>{item}</th>;
function clickReport() {
  alert("Reported Taken");
}
const renderOrderBody = (item, index) => (
  <tr key={index}>
    <td>{item.id}</td>
    <td>{item.username}</td>
    <td>{item.firstname}</td>
    <td>{item.lastname}</td>
    <td>{item.phone}</td>
    <td>{item.address}</td>
  </tr>
);

const Dashboard = () => {
  const themeReducer = useSelector((state) => state.ThemeReducer.mode);

  return (
    <div>
      <h2 className="page-header">My DNA</h2>
      <div className="row">
        <div className="col-6"></div>
        <div className="col-12">
          <div className="card">
            <div className="card__header">
              <h3>My Profile</h3>
            </div>
            <div className="card__body">
              <Table
                headData={MyProfile.header}
                renderHead={(item, index) => renderOrderHead(item, index)}
                bodyData={MyProfile.body}
                renderBody={(item, index) => renderOrderBody(item, index)}
              />
              <h3>My Connections</h3>
              <Table
                headData={MyConnections.header}
                renderHead={(item, index) => renderOrderHead(item, index)}
                bodyData={MyConnections.body}
                renderBody={(item, index) => renderOrderBody(item, index)}
              />
            </div>
            <div className="card__footer">
              <Link to="/">view all</Link>
            </div>
          </div>
        </div>
        <div className="col-6">
          <div className="card">
            <div className="card__header">
              <h3>Add Connection</h3>
            </div>
            <div className="card__body">
              <form>
                <div>
                  <label>
                    User ID:
                    <input class="textfield" type="text" name="NewUserID" />
                  </label>
                  <input class="button" type="submit" value="Add New Connection" />
                </div>
              </form>
            </div>
            <div className="card__footer">
              <Link to="/">view all</Link>
            </div>
          </div>
        </div>
        <div className="col-6">
          <div className="card">
            <div className="card__header">
              <h3>Add Medications</h3>
            </div>
            <div className="card__body">
              <form>
                <div>
                  <label>
                    Medication Name:
                    <input class="textfield" type="text" name="NewMedicationName" />
                  </label>
                  
                </div>
                <div>
                  <label>
                    Schedule Date:
                    <input class="textfield" type="Date" name="NewMedicationDate" />
                  </label>
                  <input class="button" type="submit" value="Add New Medication" />
                </div>
              </form>
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
