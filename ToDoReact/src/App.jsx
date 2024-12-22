import React from 'react'
import './App.scss'
import Task from './components/Task/Task'
import Navbar from './components/Navbar/Navbar'
import Create from './components/Create/Create'

function App() {
	const [tasks, setTasks] = React.useState([])
	const [openCreateWindow, setOpenCreateWindow] = React.useState(false)

	const handleOpen = () => {
		setOpenCreateWindow(openCreateWindow => !openCreateWindow)
		console.log('Working!')
	}

	const fetchData = async () => {
		try {
			const response = await fetch('http://localhost:5149/Tasks').then(
				response => response.json()
			)
			setTasks(response)
		} catch (error) {
			console.error(`Fetch error: ${error}`)
		}
	}

	React.useEffect(() => {
		fetchData()
	}, [])

	const notStartedTasks = tasks.filter(task => task.status === 1)
	const inProgressTasks = tasks.filter(task => task.status === 2)
	const doneTasks = tasks.filter(task => task.status === 3)

	return (
		<div className='wrapper'>
			<Navbar handleClick={handleOpen} />
			<div className='task__content'>
				<div className='status__ns'>
					<h4>Необходимо сделать</h4>
					<div className='task__container'>
						{notStartedTasks.map(task => (
							<Task
								key={task.id}
								title={task.title}
								description={task.description}
							/>
						))}
					</div>
				</div>
				<div className='status__progress'>
					<h4>В процессе</h4>
					<div className='task__container'>
						{inProgressTasks.map(task => (
							<Task
								key={task.id}
								title={task.title}
								description={task.description}
							/>
						))}
					</div>
				</div>
				<div className='status__done'>
					<h4>Выполнено</h4>
					<div className='task__container'>
						{doneTasks.map(task => (
							<Task
								key={task.id}
								title={task.title}
								description={task.description}
							/>
						))}
					</div>
				</div>
			</div>
			{<Create />}
		</div>
	)
}

export default App
