import React, {useEffect} from 'react'

import { Link } from 'react-router-dom'

import Chart from 'react-apexcharts'

import { useSelector } from 'react-redux'

import StatusCard from '../components/status-card/StatusCard'

import Table from '../components/table/Table'

import Badge from '../components/badge/Badge'

import statusCards from '../assets/JsonData/status-card-data.json'

const latestOrders = {
    header: [
        "Medication id",
        "User",
        "Medication",
        "date",
        "status",
        "Report",
    ],
    body: [
        {
            id: "#OD1711",
            user: "john doe",
            date: "5 Mar 2022",
            price: "Donepezil",
            status: "Taken"
        },
        {
            id: "#OD1712",
            user: "john doe",
            date: "5 Mar 2022",
            price: "Rivastigmine",
            status: "Not Taken"
        },
        {
            id: "#OD1713",
            user: "john doe",
            date: "6 Mar 2022",
            price: "Donepezil",
            status: "Pending"
        },
        {
            id: "#OD1714",
            user: "john doe",
            date: "6 Mar 2022",
            price: "Rivastigmine",
            status: "Pending"
        },
        {
            id: "#OD1715",
            user: "john doe",
            date: "7 Mar 2022",
            price: "Donepezil",
            status: "Pending"
        },
        {
            id: "#OD1716",
            user: "john doe",
            date: "7 Mar 2022",
            price: "Rivastigmine",
            status: "Pending"
        }
    ]
}

const orderStatus = {
    "shipping": "primary",
    "Pending": "warning",
    "Taken": "success",
    "Not Taken": "danger"
}

const renderOrderHead = (item, index) => (
    <th key={index}>{item}</th>
)
function clickReport(){
    alert('Reported Taken');
}
const renderOrderBody = (item, index) => (
    <tr key={index}>
        <td>{item.id}</td>
        <td>{item.user}</td>
        <td>{item.price}</td>
        <td>{item.date}</td>
        <td>
            <Badge type={orderStatus[item.status]} content={item.status}/>
        </td>
        <td>
            <button onClick={clickReport} type="primary">Report Taken</button>
        </td>
    </tr>
)

const Dashboard = () => {

    const themeReducer = useSelector(state => state.ThemeReducer.mode)

    return (
        <div>
            <h2 className="page-header">Dashboard</h2>
            <div className="row">
                <div className="col-6">
                </div>
                <div className="col-12">
                    <div className="card">
                        <div className="card__header">
                            <h3>My Medication</h3>
                        </div>
                        <div className="card__body">
                            <Table
                                headData={latestOrders.header}
                                renderHead={(item, index) => renderOrderHead(item, index)}
                                bodyData={latestOrders.body}
                                renderBody={(item, index) => renderOrderBody(item, index)}
                            />
                        </div>
                        <div className="card__footer">
                            <Link to='/'>view all</Link>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Dashboard
