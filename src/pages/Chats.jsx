import React from 'react'

import Table from '../components/table/Table'

import customerList from '../assets/JsonData/chat-log.json'

const customerTableHead = [
    '',
    'name',
    'email',
    'phone',
    'missed calls',
    'location'
]

const renderHead = (item, index) => <th key={index}>{item}</th>

const renderBody = (item, index) => (
    <tr key={index}>
        <td>{item.id}</td>
        <td>{item.name}</td>
        <td>{item.email}</td>
        <td>{item.phone}</td>
        <td>{item.missed_calls}</td>
        <td>{item.location}</td>
        <td>
            <button type="primary">
            Call
            </button>
        </td>
        <td>
            <button type="primary">
            Message
            </button>
        </td>
    </tr>
)

/*
<td>
            <button onClick={alert("Calling...")} type="primary">
            Call
            </button>
        </td>
        <td>
            <button onClick={alert("Messaging...")} type="primary">
            Message
            </button>
        </td>

*/


const Chats = () => {
    return (
        <div>
            <h2 className="page-header">
                Chats
            </h2>
            <div className="row">
                <div className="col-12">
                    <div className="card">
                        <div className="card__body">
                            <Table
                                limit='10'
                                headData={customerTableHead}
                                renderHead={(item, index) => renderHead(item, index)}
                                bodyData={customerList}
                                renderBody={(item, index) => renderBody(item, index)}
                            />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Chats
