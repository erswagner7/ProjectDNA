import React from 'react'

import { Route, Switch } from 'react-router-dom'

import MyDay from '../pages/MyDay'
import Chats from '../pages/Chats'
import MyDNA from '../pages/MyDNA'
import Settings from '../pages/Settings'


const Routes = () => {
    return (
        <Switch>
            <Route path='/' exact component={MyDay}/>
            <Route path='/chats' component={Chats}/>
            <Route path='/mydna' component={MyDNA}/>
            <Route path='/settings' component={Settings}/>
        </Switch>
    )
}

export default Routes
