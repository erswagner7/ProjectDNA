import React, { useState, useEffect } from "react";

import { useSelector } from "react-redux";

import ImageUploading from "react-images-uploading"

import user_image from "../components/topnav/TopNav"

import './Profile.css'

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

const renderOrderHead = (item, index) => <th key={index}>{item}</th>;

const renderOrderBody = (item, index) => (
  <tr key={index}>
    <td>{item.profileImage}</td>
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
  
  const [images, setImages] = useState([]);
  const [imageURLs, setImageURLs] = useState([]);

  useEffect(() => {
      if (images.length < 1) return;
      const newImageURLs = [];
      images.forEach(image => newImageURLs.push(URL.createObjectURL(image)));
      setImageURLs(newImageURLs);
  }, [images]);



    function onImageChange(e) {
        setImages([...e.target.files]);
    }

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
              <table
                headData={MyProfile.header}
                renderHead={(item, index) => renderOrderHead(item, index)}
                bodyData={MyProfile.body}
                renderBody={(item, index) => renderOrderBody(item, index)}
              />
            </div>
          </div>
            <div>
            <input type="file" multiple accept="image/*" onChange={onImageChange} />
            {imageURLs.map(imageSrc => <img src={imageSrc} />)}

              <input class="button" type="submit" value="Other User Settings" />
          </div>
        </div>
      </div>
    </div>
  );
};

export default Dashboard;