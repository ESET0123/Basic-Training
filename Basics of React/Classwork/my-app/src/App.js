import Counter from './components/Counter.js';
import EventComponent from './components/EventComponent.js';
import LoginComponent from './components/LoginComponent.js';
import UseEffectComponent from './components/useEffectComponent.js';
import UseRefComponent from './components/useRefComponent.js';
import ParentComponent from './components/ParentComponent.js';


function App() {
  return (
    <div>
      <Counter/>
      <EventComponent/>
      <LoginComponent/>
      <UseEffectComponent/>
      <UseRefComponent/>
      <ParentComponent/>
    </div>
  );
}

export default App;
