import React, { useEffect } from "react";

import './MyDay.css'

import { useSelector } from "react-redux";

import Table from "../components/table/Table";


const MyProfile = {
  header: [
    "Profile Image",
    "User id",
    "Username",
    "First Name",
    "Last Name",
    "Phone #",
    "Address",
  ],
  body: [
    {
      profileImage: '',
      id: "#0001",
      username: "johnD123",
      firstname: "John",
      lastname: "Doe",
      phone: "440-555-5555",
      address: "123 notreal st",
    },
  ],
};

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
                bodyData={MyProfile.body}
              />
            </div>
          </div>
            <div>
              <input class="button" type="submit" value="Other User Settings" />
          </div>
        </div>
      </div>
    </div>
  );
};

export default Dashboard;