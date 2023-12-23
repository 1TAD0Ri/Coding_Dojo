import React, { useState } from 'react';


const Tabs = ({ items }) => {
    const [activeTab, setActiveTab] = useState(0);

    return (
        <div className="tabs">
            <ul className="tab-headers">
                {items.map((item, index) => (
                    <li
                        key={index}
                        className={`tab-header ${index === activeTab ? 'active' : ''}`}
                        onClick={() => setActiveTab(index)}
                    >
                        {item.label}
                    </li>
                ))}
            </ul>
            <div className="tab-content">
                {items[activeTab].content}
            </div>
        </div>
    );
};

export default Tabs;