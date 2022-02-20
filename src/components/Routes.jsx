import React from 'react'

import { Route, Switch } from 'react-router-dom'

import MyDay from '../pages/MyDay'
import Chats from '../pages/Chats'
import MyDNA from '../pages/MyDNA'
import Settings from '../pages/Settings'
import Profile from '../pages/Profile'

const Routes = () => {
    return (
        <Switch>
            <Route path='/' exact component={MyDay}/>
            <Route path='/chats' component={Chats}/>
            <Route path='/mydna' component={MyDNA}/>
            <Route path='/settings' component={Settings}/>
            <Route path='/profile' component={Profile}/>
        </Switch>
    )
}

export default Routes
