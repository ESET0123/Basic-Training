import { createContext, useState } from 'react';

import Counter from './components/Counter.js';
import EventComponent from './components/EventComponent.js';
import LoginComponent from './components/LoginComponent.js';
import UseEffectComponent from './components/useEffectComponent.js';
import UseRefComponent from './components/useRefComponent.js';
import ParentComponent from './components/ParentComponent.js';
import UseContextComponent from './components/UseContextComponent.js';
import UseReducerComponent from './components/UseReducerComponent.js';
import CallAnApiComponent from './components/CallAnApiComponent.js';

const Context = createContext(null);

export {Context};

function App() {
  const [theme, setTheme]=useState('light');
  const [count, setCount]=useState(0);
  return (
    <Context.Provider value={{
      theme:theme,
      setTheme:setTheme,
      count: count,
      setCount:setCount
    }}>
      <CallAnApiComponent/>
      <UseReducerComponent/>
      {/* <div className='App'>
        <Counter/>
        <EventComponent/>
        <LoginComponent/>
        <UseEffectComponent/>
        <UseRefComponent/>
        <ParentComponent/>
      </div> */}
      {/* <UseContextComponent/> */}
    </Context.Provider>
  );
}

export default App;
