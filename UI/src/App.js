import logo from './logo.svg';
import './App.css';
import { useEffect, useState } from 'react';

function App() {
  const [text, setText] = useState('');
  useEffect(() => fetch('/api/items').then(response => response.json()).then(data => {
    setText(data.displayName);
  }));

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React from {text}
        </a>
      </header>
    </div>
  );
}

export default App;
