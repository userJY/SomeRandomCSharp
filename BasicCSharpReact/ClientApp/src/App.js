//refactored default App.js to functional style
import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import Basic from './components/Basic'; //This is the file we developed

import './custom.css'
const App = (props) => {
  return (
    <Layout>
      <Route exact path='/' component={Home} />
      <Route path ='/basic' component={Basic} /> 
    </Layout>
  );
}
export default App
