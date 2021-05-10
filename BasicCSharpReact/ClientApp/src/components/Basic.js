import React, {useState, Component} from 'react';
import axios from 'axios'

const Basic = (props) => {
    const [tBox, settBox] = useState("");
    const [output,setoutput] = useState("The server return data will appear here");
    const submitEvent = (event) => {
        sendMsg(tBox)
    }
    const sendMsg = async (textinput) => {
        const response = await axios.get(`Basic/${textinput}`);
        //above call GET localhost.com:5001/Basic/blah 
        //to .NET 5 server controller
        const data = await response.data;
        //server controller will return string 'Server returned blah'
        console.log(data);

        setoutput(data);
        
    }

    return(
        <div>
            <input type = "text" id = "BasicTxtBox" onChange = {event => settBox(event.target.value)}/>
            <button type = "button" onClick = {submitEvent}>Send GET request To ASP.NET server's BasicController.cs</button>
            <p>{output}</p>
        </div>
    )
}
export default Basic;