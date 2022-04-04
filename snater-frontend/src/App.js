import React from "react";
import "./app.scss";

import Sidebar from "./components/Sidebar";
import PageContent from "./components/PageContent";

function App() {
  return (
    <div>
      <Sidebar />
      <PageContent />
    </div>
  );
}

export default App;
