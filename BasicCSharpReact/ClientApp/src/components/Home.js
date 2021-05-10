import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>BareBones basic React + ASP.net Core App</h1>
        <p>Simple stripped away template to learn ASP.NET and react. 
          The file of interests</p> 
          <p>FRONTEND: Basic.js in 
          ClientApp/src/components/Basic.js 
          </p>
          <p>
          BACKEND: BasicController.cs in 
          Controllers/BasicController.cs</p>
      </div>
    );
  }
}
