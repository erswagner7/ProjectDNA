import { useEffect } from 'react';
import React from 'react'

function setColor(color){
    document.documentElement.style.setProperty('--main-bg', color)

    if (color == "blue")
    {
        document.documentElement.style.setProperty('--second-bg', "#4682B4")
        document.documentElement.style.setProperty('--txt-color', "#FFFFFF")
    } else if (color == "green")
    {
        document.documentElement.style.setProperty('--second-bg', "#00FF00")
        document.documentElement.style.setProperty('--txt-color', "#FFFFFF")
    } else if (color == "red")
    {
        document.documentElement.style.setProperty('--second-bg', "#FF8DA7")
        document.documentElement.style.setProperty('--txt-color', "#FFFFFF")
    } else if (color == "black")
    {
        document.documentElement.style.setProperty('--second-bg', "#8A8A8A")
        document.documentElement.style.setProperty('--txt-color', "#FFFFFF")
    } else if (color == "white")
    {
        document.documentElement.style.setProperty('--second-bg', "#fafafb")
        document.documentElement.style.setProperty('--txt-color', "#000000")
    }


}

function setFontSize(){
    alert("Work in Progress");
}

const Settings = () => {
    useEffect(() =>{
        const color = getComputedStyle(document.documentElement).getPropertyValue('--main-bg')
        console.log(color)
    })
    return (
        <div>
            <h2 className="page-header">Settings</h2>
            <div className="row">
                <div className="col-6">
                </div>
                <div className="col-12">
                    <div className="card">
                        <div className="card__header">
                            <h3>Change Color Theme</h3>
                            <button onClick={() => setColor('black')} type="primary">Black</button>
                            <button onClick={() => setColor('green')} type="primary">Green</button>
                            <button onClick={() => setColor('red')} type="primary">Red</button>
                            <button onClick={() => setColor('blue')} type="primary">Blue</button>
                            <button onClick={() => setColor('white')} type="primary">White</button>

                            <h3>Change Font Size</h3>
                            <button onClick={() => setFontSize('')} type="primary">Small</button>
                            <button onClick={() => setFontSize('')} type="primary">Default</button>
                            <button onClick={() => setFontSize('')} type="primary">Large</button>

                        </div>
                        <div className="card__body">
                            
                        </div>
                        <div className="card__footer">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Settings
