import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Layout from "./components/Layout";
import { List } from './components/List';
import Form from './components/Form';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<List />} />
          <Route path="/details" element={<Form />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
