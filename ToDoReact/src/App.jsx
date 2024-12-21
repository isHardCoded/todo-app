import React from 'react'
import Header from './components/Header/Header'
import Menu from './components/Menu/Menu'
import TaskBlock from './components/TaskBlock/TaskBlock'
import '../src/App.scss'

function App() {
	return (
		<>
			<Header />
			<div className='main-container'>
				<Menu />
				<div className='tasks-container'>
					<TaskBlock />
				</div>
			</div>
		</>
	)
}

export default App
